Shader "Hirabiki/ScreenSpace/GrabPass Overlay"
{
	Properties {
		
		_PillarTex ("Frame Texture Left/Right", 2D) = "black" {}
		_LetterTex ("Frame Texture Top/Bottom", 2D) = "black" {}
		_LogoTex ("Logo Texture", 2D) = "black" {}
		[Header(Position Settings)]
		
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
		_FadeDist ("Attach distance", range(0, 4)) = 1
		
		
	}
    SubShader
    {
        // Draw ourselves after all opaque geometry
        Tags { "Queue" = "Overlay" "DisableBatching" = "True" }
		
        GrabPass { "_HirabikiGrabOverlay" }
        Pass
        {
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #include "UnityCG.cginc"
			
			uniform float _FadeDist;
			uniform float _ResizeMode, _OutlineSize, _Rotation, _RotationLogo;
			
			uniform float _AnchorX;
			
			sampler2D _HirabikiGrabOverlay, _PillarTex, _LetterTex, _LogoTex;
			float4 _LogoTex_TexelSize, _GrabPassST, _LogoST;
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
				float isCam = (0.5 * _FadeDist > distFromObject) * (abs(UNITY_MATRIX_V._12) >= 0.00000174532926);
#endif
				o.pos = lerp(UnityObjectToClipPos(float4(0,0,0,1)), mul(UNITY_MATRIX_P, v.vertex * float4(1,1,0,1) + float4(0.0, 0.0, -0.001 -_ProjectionParams.y, 0.0)), isCam);
				
				float aRatio = lerp(1.777777777, _ScreenParams.x / _ScreenParams.y, isCam);
				float sRatio = _ScreenParams.x / _ScreenParams.y;
				
				float4 rawPos = lerp(v.uv, ComputeNonStereoScreenPos(o.pos), isCam);
				float2 scrUVRaw = (rawPos.xy / rawPos.w - 0.5) / _GrabPassST.xy + _GrabPassST.zw + 0.5;
				float2 scrUV = (scrUVRaw - 0.5) * float2(aRatio, 1.0);
				
				float t = _Rotation * 0.01745329251;
				scrUV = float2(cos(t) * scrUV.x - sin(t) * scrUV.y, sin(t) * scrUV.x + cos(t) * scrUV.y);
				
				float2 texUV = scrUV / lerp(min(1.777777777 / sRatio, 1.0) * float2(sRatio, 1.0), float2(aRatio, 1.0), isCam) + 0.5;
                o.grabPos = texUV;
                return o;
            }
			
            half4 frag(v2f i) : SV_Target
            {
				float2 iuv = i.grabPos;
				float iRatio = _ScreenParams.y / _ScreenParams.x;
				float2 bgTexSX = _ScreenParams.xy / _ScreenParams.y;
				float2 bgTexSY = _ScreenParams.xy / _ScreenParams.x;
				
				float t = _RotationLogo * 0.01745329251;
				float2x2 iuvRot = float2x2(cos(t), -sin(t), sin(t), cos(t));
				
				float2 scale2 = _LogoTex_TexelSize.xy * max(_LogoTex_TexelSize.z, _LogoTex_TexelSize.w);
				float2 iuv2 = mul(iuvRot, ((i.grabPos - float2(_AnchorX, 0.5)) * bgTexSX) - _LogoST.zw) / _LogoST.xy * scale2 + float2(_AnchorX, 0.5);
				
				float2 lineSize = float2(max(0.0, _OutlineSize), min(0.0, _OutlineSize));
				half4 col0 = lerp(_OutlineColor, tex2D(_HirabikiGrabOverlay, iuv),
					saturate(_ScreenParams.x * 0.5 - max(abs(iuv.x - 0.5) + lineSize.x * iRatio, abs(iuv.y - 0.5) + lineSize.x) * _ScreenParams.x + 1.5));
				half4 col1 = lerp(
					tex2D(_LetterTex, (iuv - float2(0.0, 0.5)) * bgTexSY + ((iuv.y > 0.5) - 0.5) * float2(0.0, 1.0 - bgTexSY.y)),
					tex2D(_PillarTex, (iuv - float2(0.5, 0.0)) * bgTexSX + ((iuv.x > 0.5) - 0.5) * float2(1.0 - bgTexSX.x, 0.0)),
					saturate(_ScreenParams.x * 0.5 - abs(iuv.y - 0.5) * _ScreenParams.x + 0.5));
				
				half4 col01 = lerp(col1, col0, saturate(_ScreenParams.x * 0.5 - max(abs(iuv.x - 0.5) + lineSize.y * iRatio, abs(iuv.y - 0.5) + lineSize.y) * _ScreenParams.x + 0.5));
				half4 col2 = tex2D(_LogoTex, iuv2);
				half4 col = lerp(col01, col2, col2.a * saturate(_ScreenParams.x * abs(_LogoST.x) * 0.5 - max(abs(iuv2.x - 0.5), abs(iuv2.y - 0.5)) * _ScreenParams.x * abs(_LogoST.x) + 0.5));
				
				return col;
            }
			
            ENDCG
        }

    }
}