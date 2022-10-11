Shader "Hirabiki/ScreenSpace/RenderTexture Overlay Simple"
{
	Properties {
		_MainTex ("Main Texture", 2D) = "white" {}
		_Color ("Background Color", color) = (0,0,0,1)
		_FadeDist ("Size", range(0, 1)) = 0.3
		[Enum(Fill,0,Fit,1,Stretch,2)] _ResizeMode("Resize mode", float) = 1
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
			uniform float _ResizeMode, _ShowPreview, _AllowDesktop;
			
			sampler2D _MainTex;
			float4 _MainTex_TexelSize;
			half4 _Color;
			
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
				float2 scrUVRaw = rawPos.xy / rawPos.w;
				float2 scrUV = (scrUVRaw - 0.5) * lerp(float2(1.777777777, 1.0), _ScreenParams.xy / _ScreenParams.y, isCam);
				
				
				
				
				float2 texUV = scrUV * _MainTex_TexelSize.xy * _MainTex_TexelSize.w * scale + 0.5;
                o.grabPos = lerp(texUV, scrUVRaw, max(_ResizeMode, 1.0) - 1.0);
                return o;
            }
			
            half4 frag(v2f i) : SV_Target
            {
				
				
				
				
				
				
				
				
				
				
				
				
				half4 col0 = tex2D(_MainTex, i.grabPos);
				
				half4 col1 = _Color;
				
				
				
				
				
				
				half4 col = lerp(col1, col0, saturate(_ScreenParams.x * 0.5 - max(abs(i.grabPos.x - 0.5), abs(i.grabPos.y - 0.5)) * _ScreenParams.x + 1.0));
				
				return col;
            }
			
            ENDCG
        }

    }
}