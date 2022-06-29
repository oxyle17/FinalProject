void MainLight_half(float3 WorldPos, out half3 Direction, out half3 Color, out half DistanceAtten, out half ShadowAtten)
{
#if defined(SHADERGRAPH_PREVIEW)
   Direction = half3(0.5, 0.5, -0.25);
   Color = 1;
   DistanceAtten = 1;
   ShadowAtten = 1;
#else
    half cascadeIndex = ComputeCascadeIndex(WorldPos);
    half4 shadowCoord = mul(_MainLightWorldToShadow[cascadeIndex], half4(WorldPos, 1.0));

   Light mainLight = GetMainLight(shadowCoord);
   Direction = mainLight.direction;
   Color = mainLight.color;
   DistanceAtten = mainLight.distanceAttenuation;
 
    ShadowSamplingData shadowSamplingData = GetMainLightShadowSamplingData();
    half shadowStrength = GetMainLightShadowStrength();
    ShadowAtten = SampleShadowmap(shadowCoord, TEXTURE2D_ARGS(_MainLightShadowmapTexture, sampler_MainLightShadowmapTexture), shadowSamplingData, shadowStrength, false);

#endif
}