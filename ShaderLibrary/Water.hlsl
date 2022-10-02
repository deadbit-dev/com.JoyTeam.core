#ifndef WATER_INCLUDED
#define WATER_INCLUDED

        #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Core.hlsl"

        #define UNITY_MATRIX_MVP mul(UNITY_MATRIX_VP, UNITY_MATRIX_M)

        struct MeshData
        {
            float4 vertex : POSITION;
            float4 normal : NORMAL;
        };

        struct FragmentData
        {
            float4 position : SV_POSITION;
        };

        CBUFFER_START(UnityPerMaterial)

        float4 _BaseColor;
        float4 _ShallowWaterColor;
        float _Depth;
        float _Strength;

        CBUFFER_END

        FragmentData VertexPass(MeshData input)
        {
            FragmentData output;
            output.position = mul(UNITY_MATRIX_MVP, input.vertex);
            return output;
        }

        float4 FragmentPass(FragmentData input) : SV_Target
        {
            return _ShallowWaterColor;
        }

#endif // WATER_INCLUDED