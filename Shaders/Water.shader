Shader "Universal Render Pipeline/Water"
{
    Properties
    {
        _BaseColor ("Base Color", Color) = (0, 0, 1, 1)
        _ShallowWaterColor ("Shallow Water Color", Color) = (0, 0, 0.5, 1)
        _Depth ("Depth", float) = 0.5
        _Strength ("Strength", float) = 0.3

    }

    SubShader
    {
        Tags
        {
            "RenderPipeline" = "UniversalRenderPipeline"
            "RenderType" = "Opaque"
            "Queue" = "Geometry"
        }

        Pass
        {
            ZWrite On

            HLSLPROGRAM

            #pragma vertex VertexPass
            #pragma fragment FragmentPass

            #include "../ShaderLibrary/Water.hlsl"

            ENDHLSL
        }
    }

    //FallBack "Hidden/InternalErrorShader"
}