Shader "Unlit/DearImGui"
{
    SubShader
    {
        Tags { "RenderType" = "Transparent" "RenderPipeline" = "UniversalPipeline" "PreviewType" = "Plane" }
        LOD 100

        Lighting Off
        Cull Off ZWrite On ZTest Always
        Blend SrcAlpha OneMinusSrcAlpha

        Pass
        {
            Name "DEARIMGUI PROCEDURAL URP"

            HLSLPROGRAM
            #pragma vertex vert
            #pragma fragment ImGuiPassFrag

            struct ImVert   // same layout as ImDrawVert
            {
                float2 vertex   : POSITION;
                float2 uv       : TEXCOORD0;
                uint   color    : TEXCOORD1; // gets reordered when using COLOR semantics
            };

            struct Varyings
            {
                float4 vertex   : SV_POSITION;
                float2 uv       : TEXCOORD0;
                half4  color    : COLOR;
            };

            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Core.hlsl"
            #ifndef UNITY_COLORSPACE_GAMMA
            #include "Packages/com.unity.render-pipelines.core/ShaderLibrary/Color.hlsl"
            #endif

            TEXTURE2D(_Texture);
            SAMPLER(sampler_Texture);

            half4 unpack_color(uint c)
            {
                half4 color = half4(
                    (c      ) & 0xff,
                    (c >>  8) & 0xff,
                    (c >> 16) & 0xff,
                    (c >> 24) & 0xff
                ) / 255;
            #ifndef UNITY_COLORSPACE_GAMMA
                color.rgb = FastSRGBToLinear(color.rgb);
            #endif
                return color;
            }

            Varyings ImGuiPassVertex(ImVert input)
            {
                Varyings output  = (Varyings)0;
                output.vertex    = TransformWorldToHClip(TransformObjectToWorld(float3(input.vertex, 0.0)));
                output.uv        = float2(input.uv.x, 1 - input.uv.y);
                output.color     = unpack_color(input.color);
                return output;
            }

            StructuredBuffer<ImVert> _Vertices;
            int _BaseVertex;

            Varyings vert(uint id : SV_VertexID)
            {
#if defined(SHADER_API_D3D11) || defined(SHADER_API_XBOXONE)
                // BaseVertexLocation is not automatically added to SV_VertexID
                id += _BaseVertex;
#endif
                ImVert v = _Vertices[id];
                return ImGuiPassVertex(v);
            }

            half4 ImGuiPassFrag(Varyings input) : SV_Target
            {
                //return float4(1, 0, 0, 0.4);
                return input.color * SAMPLE_TEXTURE2D(_Texture, sampler_Texture, input.uv);
            }
            ENDHLSL
        }
    }

// shader for builtin rendering and HDRP
    SubShader
    {
        Tags { "Queue"="Transparent" "IgnoreProjector"="True" "RenderType"="Transparent" "PreviewType"="Plane" }
        LOD 100

        Lighting Off
        Cull Off ZWrite On ZTest Always
        Blend SrcAlpha OneMinusSrcAlpha

        Pass
        {
            Name "DEARIMGUI PROCEDURAL BUILTIN"

            CGPROGRAM
            #pragma vertex vert
            #pragma fragment ImGuiPassFrag

            #ifndef DEARIMGUI_BUILTIN_INCLUDED
            #define DEARIMGUI_BUILTIN_INCLUDED

            #include "UnityCG.cginc"
            #ifndef DEARIMGUI_COMMON_INCLUDED
            #define DEARIMGUI_COMMON_INCLUDED

            struct ImVert   // same layout as ImDrawVert
            {
                float2 vertex   : POSITION;
                float2 uv       : TEXCOORD0;
                uint   color    : TEXCOORD1; // gets reordered when using COLOR semantics
            };

            struct Varyings
            {
                float4 vertex   : SV_POSITION;
                float2 uv       : TEXCOORD0;
                half4  color    : COLOR;
            };

            #endif

            sampler2D _Texture;

            half4 unpack_color(uint c)
            {
                half4 color = half4(
                    (c      ) & 0xff,
                    (c >>  8) & 0xff,
                    (c >> 16) & 0xff,
                    (c >> 24) & 0xff
                ) / 255;
            #ifndef UNITY_COLORSPACE_GAMMA
                color.rgb = GammaToLinearSpace(color.rgb);
            #endif
                return color;
            }

            Varyings ImGuiPassVertex(ImVert input)
            {
                Varyings output  = (Varyings)0;
                output.vertex    = UnityObjectToClipPos(float4(input.vertex, 0, 1));
                output.uv        = float2(input.uv.x, 1 - input.uv.y);
                output.color     = unpack_color(input.color);
                return output;
            }

            half4 ImGuiPassFrag(Varyings input) : SV_Target
            {
                return input.color * tex2D(_Texture, input.uv);
            }

            #endif

            StructuredBuffer<ImVert> _Vertices;
            int _BaseVertex;

            Varyings vert(uint id : SV_VertexID)
            {
#if defined(SHADER_API_D3D11) || defined(SHADER_API_XBOXONE)
                // BaseVertexLocation is not automatically added to SV_VertexID
                id += _BaseVertex;
#endif
                ImVert v = _Vertices[id];
                return ImGuiPassVertex(v);
            }
            ENDCG
        }
    }
}