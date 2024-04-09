
Shader "Lit/WallTiling"
{
    Properties
    {
        _MainTex ("Texture", 2D) = "white" {}
        _Color ("Color", Color) = (.25, .5, .5, 1)
    }
    SubShader
    {
        Tags { "RenderType"="Opaque" "RenderPipeline" = "UniversalPipeline" }
        LOD 100

        Pass
        {           
            
            HLSLPROGRAM
            #pragma vertex vert
            #pragma fragment frag   
            #include "UnityCG.cginc"            
            // #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Core.hlsl"

            // To make the Unity shader SRP Batcher compatible, declare all
            // properties related to a Material in a a single CBUFFER block with
            // the name UnityPerMaterial.
            CBUFFER_START(UnityPerMaterial)
                // The following line declares the _BaseColor variable, so that you
                // can use it in the fragment shader.
                float4 _Color;
            CBUFFER_END

            struct appdata
            {
                float4 vertex : POSITION;
                float2 uv : TEXCOORD0;
            };

            struct v2f
            {
                float2 uv : TEXCOORD0;
                float4 vertex : SV_POSITION;
            };

            sampler2D _MainTex;
            float4 _MainTex_ST;

            v2f vert (appdata v)
            {
                v2f o;
                // o.vertex = UnityObjectToClipPos(v.vertex);
                o.vertex = mul(UNITY_MATRIX_MVP, v.vertex);

                // Gets the xy position of the vertex in worldspace.
                float2 worldXY = mul(unity_ObjectToWorld, v.vertex).xy;
                // Use the worldspace coords instead of the mesh's UVs.
                o.uv = TRANSFORM_TEX(worldXY, _MainTex);

                return o;
            }

            float4 frag (v2f i) : SV_Target
            {                   
                float4 col = tex2D(_MainTex, i.uv);
                return col * _Color;
            }
            ENDHLSL
        }
    }
}
