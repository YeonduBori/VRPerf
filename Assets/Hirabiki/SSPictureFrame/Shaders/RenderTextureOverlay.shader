Shader "Hirabiki/ScreenSpace/RenderTexture Overlay"
{
	Properties {
		_MainTex ("Main RenderTexture", 2D) = "white" {}
		_PillarTex ("Frame Texture Left/Right", 2D) = "black" {}
		_LetterTex ("Frame Texture Top/Bottom", 2D) = "black" {}
		_LogoTex ("Logo Texture", 2D) = "black" {}
		[Header(Position Settings)]
		[Enum(Fill,0,Fit,1,Stretch,2)] _ResizeMode("Resize mode", float) = 1
		_GrabPassST ("Frame Size/Offset", vector) = (1,1,0,0)
		_LogoST ("Logo Size/Offset", vector) = (1,1,0,0)
		[Enum(Left,0,Center,0.5,Right,1)] _AnchorX("Logo Anchor", float) = 1
		[Header(Outline Settings)]
		_OutlineColor ("Outline Color", color) = (1,1,1,1)
		_OutlineSize ("Outline Size", range(-0.2, 0.2)) = -0.01
		[Header(Rotation Settings)]
		_Rotation ("Frame Rotation", float) = 0
		_RotationLogo ("Logo Rotation", float) = 0
		[Header(Vision Settings)]
		_FadeDist ("Attach distance", range(0, 4)) = 0.3
		[Enum(No,0,Yes,1)] _AllowDesktop("Camera only?", float) = 1
		[Enum(No,0,Yes,1)] _ShowPreview("Show preview?", float) = 1
	}
    SubShader
    {
        // Draw ourselves after all opaque geometry
        Tags { "DisableBatching" = "True" }
		
		
        Pass
        {
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #include "UnityCG.cginc"
			
			uniform float _FadeDist;
			uniform float _ResizeMode, _OutlineSize, _Rotation, _RotationLogo;
			uniform float _ShowPreview, _AllowDesktop;
			uniform float _AnchorX;
			
			sampler2D _MainTex, _PillarTex, _LetterTex, _LogoTex;
			float4 _LogoTex_TexelSize, _GrabPassST, _LogoST, _MainTex_TexelSize;
			half4 _OutlineColor;
			
			struct appdata {
				float4 vertex : POSITION;
				float4 uv : TEXCOORD0;
			};
			
            struct v2f
            {
                float2 grabPos : TEXCOORD0;
                float4 pos : SV_POSITION;
            };

            v2f vert(appdata v) {
				v2f o;
				
				float3 objectPos = mul(unity_ObjectToWorld, float4(0.0, 0.0, 0.0, 1.0)).xyz;
				float distFromObject = distance(objectPos, _WorldSpaceCameraPos);
				
#if defined(USING_STEREO_MATRICES)
				float isCam = 0.0;
#else
				float isCam = (0.5 * _FadeDist > distFromObject) * (abs(UNITY_MATRIX_V._12) >= (0.00000174532926 * _AllowDesktop));
#endif
				o.pos = lerp(UnityObjectToClipPos(v.vertex * _ShowPreview), mul(UNITY_MATRIX_P, v.vertex * float4(1,1,0,1) + float4(0.0, 0.0, -0.001 -_ProjectionParams.y, 0.0)), isCam);
				
				float aRatio = _MainTex_TexelSize.z * _MainTex_TexelSize.y / lerp(1.777777777, _ScreenParams.x / _ScreenParams.y, isCam);
				float scale = lerp(min(aRatio, 1.0), max(aRatio, 1.0), min(1.0, _ResizeMode));
				
				float4 rawPos = lerp(v.uv, ComputeNonStereoScreenPos(o.pos), isCam);
				float2 scrUVRaw = (rawPos.xy / rawPos.w - 0.5) / _GrabPassST.xy + _GrabPassST.zw + 0.5;
				float2 scrUV = (scrUVRaw - 0.5) * lerp(float2(1.777777777, 1.0), _ScreenParams.xy / _ScreenParams.y, isCam);
				
				float t = _Rotation * 0.01745329251;
				scrUV = float2(cos(t) * scrUV.x - sin(t) * scrUV.y, sin(t) * scrUV.x + cos(t) * scrUV.y);
				
				float2 texUV = scrUV * _MainTex_TexelSize.xy * _MainTex_TexelSize.w * scale + 0.5;
                o.grabPos = lerp(texUV, scrUVRaw, max(_ResizeMode, 1.0) - 1.0);
                return o;
            }
			
            half4 frag(v2f i) : SV_Target
            {
				float2 iuv = i.grabPos;
				float iRatio = _MainTex_TexelSize.w * _MainTex_TexelSize.x;
				float2 bgTexSX = _MainTex_TexelSize.zw * _MainTex_TexelSize.y;
				float2 bgTexSY = _MainTex_TexelSize.zw * _MainTex_TexelSize.x;
				
				float t = _RotationLogo * 0.01745329251;
				float2x2 iuvRot = float2x2(cos(t), -sin(t), sin(t), cos(t));
				
				float2 scale2 = _LogoTex_TexelSize.xy * max(_LogoTex_TexelSize.z, _LogoTex_TexelSize.w);
				float2 iuv2 = mul(iuvRot, ((i.grabPos - float2(_AnchorX, 0.5)) * bgTexSX) - _LogoST.zw) / _LogoST.xy * scale2 + float2(_AnchorX, 0.5);
				
				float2 lineSize = float2(max(0.0, _OutlineSize), min(0.0, _OutlineSize));
				half4 col0 = lerp(_OutlineColor, tex2D(_MainTex, iuv),
					saturate(_ScreenParams.x * 0.5 - max(abs(iuv.x - 0.5) + lineSize.x * iRatio, abs(iuv.y - 0.5) + lineSize.x) * _ScreenParams.x + 1.5));
				half4 col1 = lerp(
					tex2D(_LetterTex, (iuv - float2(0.0, 0.5)) * bgTexSY + ((iuv.y > 0.5) - 0.5) * float2(0.0, 1.0 - bgTexSY.y)),
					tex2D(_PillarTex, (iuv - float2(0.5, 0.0)) * bgTexSX + ((iuv.x > 0.5) - 0.5) * float2(1.0 - bgTexSX.x, 0.0)),
					saturate(_ScreenParams.x * 0.5 - abs(iuv.y - 0.5) * _ScreenParams.x + 0.5));
				
				half4 col01 = lerp(col1, col0, saturate(_ScreenParams.x * 0.5 - max(abs(iuv.x - 0.5) + lineSize.y * iRatio, abs(iuv.y - 0.5) + lineSize.y) * _ScreenParams.x + 0.5));
				half4 col2 = tex2D(_LogoTex, iuv2);
				half4 col = lerp(col01, col2, col2.a * saturate(_ScreenParams.x * _LogoST.x * 0.5 - max(abs(iuv2.x - 0.5), abs(iuv2.y - 0.5)) * _ScreenParams.x * _LogoST.x + 0.5));
				
				return col;
            }
			
            ENDCG
        }

    }
}