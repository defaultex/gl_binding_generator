#if (GL_VERSION_1_3 || GL_VERSION_ES_CM_1_0 || GL_NV_PATH_RENDERING || GL_VERSION_1_5 || GL_ARB_BLEND_FUNC_EXTENDED || GL_ARB_TEXTURE_ENV_COMBINE || GL_EXT_BLEND_FUNC_EXTENDED || GL_EXT_TEXTURE_ENV_COMBINE || GL_NV_TEXTURE_ENV_COMBINE4)

public enum RegisterCombinerPname : GLenum { 
#if (GL_VERSION_1_3 || GL_VERSION_ES_CM_1_0)
    Combine = gl.Constants.GL_COMBINE, 
#endif

#if (GL_VERSION_1_3 || GL_VERSION_ES_CM_1_0)
    CombineRgb = gl.Constants.GL_COMBINE_RGB, 
#endif

#if (GL_VERSION_1_3 || GL_VERSION_ES_CM_1_0)
    CombineAlpha = gl.Constants.GL_COMBINE_ALPHA, 
#endif

#if (GL_VERSION_1_3 || GL_VERSION_ES_CM_1_0)
    RgbScale = gl.Constants.GL_RGB_SCALE, 
#endif

#if (GL_VERSION_1_3 || GL_VERSION_ES_CM_1_0)
    AddSigned = gl.Constants.GL_ADD_SIGNED, 
#endif

#if (GL_VERSION_1_3 || GL_VERSION_ES_CM_1_0)
    Interpolate = gl.Constants.GL_INTERPOLATE, 
#endif

#if (GL_VERSION_1_3 || GL_VERSION_ES_CM_1_0)
    Constant = gl.Constants.GL_CONSTANT, 
#endif

#if (GL_NV_PATH_RENDERING || GL_VERSION_1_3 || GL_VERSION_ES_CM_1_0)
    PrimaryColor = gl.Constants.GL_PRIMARY_COLOR, 
#endif

#if (GL_VERSION_1_3 || GL_VERSION_ES_CM_1_0)
    Previous = gl.Constants.GL_PREVIOUS, 
#endif

#if GL_VERSION_1_3
    Source0Rgb = gl.Constants.GL_SOURCE0_RGB, 
#endif

#if GL_VERSION_1_3
    Source1Rgb = gl.Constants.GL_SOURCE1_RGB, 
#endif

#if GL_VERSION_1_3
    Source2Rgb = gl.Constants.GL_SOURCE2_RGB, 
#endif

#if GL_VERSION_1_3
    Source0Alpha = gl.Constants.GL_SOURCE0_ALPHA, 
#endif

#if GL_VERSION_1_3
    Source1Alpha = gl.Constants.GL_SOURCE1_ALPHA, 
#endif

#if GL_VERSION_1_3
    Source2Alpha = gl.Constants.GL_SOURCE2_ALPHA, 
#endif

#if (GL_VERSION_1_3 || GL_VERSION_ES_CM_1_0)
    Operand0Rgb = gl.Constants.GL_OPERAND0_RGB, 
#endif

#if (GL_VERSION_1_3 || GL_VERSION_ES_CM_1_0)
    Operand1Rgb = gl.Constants.GL_OPERAND1_RGB, 
#endif

#if (GL_VERSION_1_3 || GL_VERSION_ES_CM_1_0)
    Operand2Rgb = gl.Constants.GL_OPERAND2_RGB, 
#endif

#if (GL_VERSION_1_3 || GL_VERSION_ES_CM_1_0)
    Operand0Alpha = gl.Constants.GL_OPERAND0_ALPHA, 
#endif

#if (GL_VERSION_1_3 || GL_VERSION_ES_CM_1_0)
    Operand1Alpha = gl.Constants.GL_OPERAND1_ALPHA, 
#endif

#if (GL_VERSION_1_3 || GL_VERSION_ES_CM_1_0)
    Operand2Alpha = gl.Constants.GL_OPERAND2_ALPHA, 
#endif

#if (GL_VERSION_1_5 || GL_VERSION_ES_CM_1_0)
    Src0Rgb = gl.Constants.GL_SRC0_RGB, 
#endif

#if (GL_VERSION_1_5 || GL_VERSION_ES_CM_1_0)
    Src1Rgb = gl.Constants.GL_SRC1_RGB, 
#endif

#if (GL_VERSION_1_5 || GL_VERSION_ES_CM_1_0)
    Src2Rgb = gl.Constants.GL_SRC2_RGB, 
#endif

#if (GL_VERSION_1_5 || GL_VERSION_ES_CM_1_0)
    Src0Alpha = gl.Constants.GL_SRC0_ALPHA, 
#endif

#if (GL_ARB_BLEND_FUNC_EXTENDED || GL_VERSION_1_5 || GL_VERSION_ES_CM_1_0)
    Src1Alpha = gl.Constants.GL_SRC1_ALPHA, 
#endif

#if (GL_VERSION_1_5 || GL_VERSION_ES_CM_1_0)
    Src2Alpha = gl.Constants.GL_SRC2_ALPHA, 
#endif

#if GL_ARB_TEXTURE_ENV_COMBINE
    CombineArb = gl.Constants.GL_COMBINE_ARB, 
#endif

#if GL_ARB_TEXTURE_ENV_COMBINE
    CombineRgbArb = gl.Constants.GL_COMBINE_RGB_ARB, 
#endif

#if GL_ARB_TEXTURE_ENV_COMBINE
    CombineAlphaArb = gl.Constants.GL_COMBINE_ALPHA_ARB, 
#endif

#if GL_ARB_TEXTURE_ENV_COMBINE
    RgbScaleArb = gl.Constants.GL_RGB_SCALE_ARB, 
#endif

#if GL_ARB_TEXTURE_ENV_COMBINE
    AddSignedArb = gl.Constants.GL_ADD_SIGNED_ARB, 
#endif

#if GL_ARB_TEXTURE_ENV_COMBINE
    InterpolateArb = gl.Constants.GL_INTERPOLATE_ARB, 
#endif

#if GL_ARB_TEXTURE_ENV_COMBINE
    ConstantArb = gl.Constants.GL_CONSTANT_ARB, 
#endif

#if GL_ARB_TEXTURE_ENV_COMBINE
    PrimaryColorArb = gl.Constants.GL_PRIMARY_COLOR_ARB, 
#endif

#if GL_ARB_TEXTURE_ENV_COMBINE
    PreviousArb = gl.Constants.GL_PREVIOUS_ARB, 
#endif

#if GL_ARB_TEXTURE_ENV_COMBINE
    Source0RgbArb = gl.Constants.GL_SOURCE0_RGB_ARB, 
#endif

#if GL_ARB_TEXTURE_ENV_COMBINE
    Source1RgbArb = gl.Constants.GL_SOURCE1_RGB_ARB, 
#endif

#if GL_ARB_TEXTURE_ENV_COMBINE
    Source2RgbArb = gl.Constants.GL_SOURCE2_RGB_ARB, 
#endif

#if GL_ARB_TEXTURE_ENV_COMBINE
    Source0AlphaArb = gl.Constants.GL_SOURCE0_ALPHA_ARB, 
#endif

#if GL_ARB_TEXTURE_ENV_COMBINE
    Source1AlphaArb = gl.Constants.GL_SOURCE1_ALPHA_ARB, 
#endif

#if GL_ARB_TEXTURE_ENV_COMBINE
    Source2AlphaArb = gl.Constants.GL_SOURCE2_ALPHA_ARB, 
#endif

#if GL_ARB_TEXTURE_ENV_COMBINE
    Operand0RgbArb = gl.Constants.GL_OPERAND0_RGB_ARB, 
#endif

#if GL_ARB_TEXTURE_ENV_COMBINE
    Operand1RgbArb = gl.Constants.GL_OPERAND1_RGB_ARB, 
#endif

#if GL_ARB_TEXTURE_ENV_COMBINE
    Operand2RgbArb = gl.Constants.GL_OPERAND2_RGB_ARB, 
#endif

#if GL_ARB_TEXTURE_ENV_COMBINE
    Operand0AlphaArb = gl.Constants.GL_OPERAND0_ALPHA_ARB, 
#endif

#if GL_ARB_TEXTURE_ENV_COMBINE
    Operand1AlphaArb = gl.Constants.GL_OPERAND1_ALPHA_ARB, 
#endif

#if GL_ARB_TEXTURE_ENV_COMBINE
    Operand2AlphaArb = gl.Constants.GL_OPERAND2_ALPHA_ARB, 
#endif

#if GL_EXT_BLEND_FUNC_EXTENDED
    Src1AlphaExt = gl.Constants.GL_SRC1_ALPHA_EXT, 
#endif

#if GL_EXT_TEXTURE_ENV_COMBINE
    CombineExt = gl.Constants.GL_COMBINE_EXT, 
#endif

#if GL_EXT_TEXTURE_ENV_COMBINE
    CombineRgbExt = gl.Constants.GL_COMBINE_RGB_EXT, 
#endif

#if GL_EXT_TEXTURE_ENV_COMBINE
    CombineAlphaExt = gl.Constants.GL_COMBINE_ALPHA_EXT, 
#endif

#if GL_EXT_TEXTURE_ENV_COMBINE
    RgbScaleExt = gl.Constants.GL_RGB_SCALE_EXT, 
#endif

#if GL_EXT_TEXTURE_ENV_COMBINE
    AddSignedExt = gl.Constants.GL_ADD_SIGNED_EXT, 
#endif

#if GL_EXT_TEXTURE_ENV_COMBINE
    InterpolateExt = gl.Constants.GL_INTERPOLATE_EXT, 
#endif

#if GL_EXT_TEXTURE_ENV_COMBINE
    ConstantExt = gl.Constants.GL_CONSTANT_EXT, 
#endif

#if GL_EXT_TEXTURE_ENV_COMBINE
    PrimaryColorExt = gl.Constants.GL_PRIMARY_COLOR_EXT, 
#endif

#if GL_EXT_TEXTURE_ENV_COMBINE
    PreviousExt = gl.Constants.GL_PREVIOUS_EXT, 
#endif

#if GL_EXT_TEXTURE_ENV_COMBINE
    Source0RgbExt = gl.Constants.GL_SOURCE0_RGB_EXT, 
#endif

#if GL_EXT_TEXTURE_ENV_COMBINE
    Source1RgbExt = gl.Constants.GL_SOURCE1_RGB_EXT, 
#endif

#if GL_EXT_TEXTURE_ENV_COMBINE
    Source2RgbExt = gl.Constants.GL_SOURCE2_RGB_EXT, 
#endif

#if GL_EXT_TEXTURE_ENV_COMBINE
    Source0AlphaExt = gl.Constants.GL_SOURCE0_ALPHA_EXT, 
#endif

#if GL_EXT_TEXTURE_ENV_COMBINE
    Source1AlphaExt = gl.Constants.GL_SOURCE1_ALPHA_EXT, 
#endif

#if GL_EXT_TEXTURE_ENV_COMBINE
    Source2AlphaExt = gl.Constants.GL_SOURCE2_ALPHA_EXT, 
#endif

#if GL_EXT_TEXTURE_ENV_COMBINE
    Operand0RgbExt = gl.Constants.GL_OPERAND0_RGB_EXT, 
#endif

#if GL_EXT_TEXTURE_ENV_COMBINE
    Operand1RgbExt = gl.Constants.GL_OPERAND1_RGB_EXT, 
#endif

#if GL_EXT_TEXTURE_ENV_COMBINE
    Operand2RgbExt = gl.Constants.GL_OPERAND2_RGB_EXT, 
#endif

#if GL_EXT_TEXTURE_ENV_COMBINE
    Operand0AlphaExt = gl.Constants.GL_OPERAND0_ALPHA_EXT, 
#endif

#if GL_EXT_TEXTURE_ENV_COMBINE
    Operand1AlphaExt = gl.Constants.GL_OPERAND1_ALPHA_EXT, 
#endif

#if GL_EXT_TEXTURE_ENV_COMBINE
    Operand2AlphaExt = gl.Constants.GL_OPERAND2_ALPHA_EXT, 
#endif

#if GL_NV_PATH_RENDERING
    ConstantNv = gl.Constants.GL_CONSTANT_NV, 
#endif

#if GL_NV_TEXTURE_ENV_COMBINE4
    Source3RgbNv = gl.Constants.GL_SOURCE3_RGB_NV, 
#endif

#if GL_NV_TEXTURE_ENV_COMBINE4
    Source3AlphaNv = gl.Constants.GL_SOURCE3_ALPHA_NV, 
#endif

#if GL_NV_TEXTURE_ENV_COMBINE4
    Operand3RgbNv = gl.Constants.GL_OPERAND3_RGB_NV, 
#endif

#if GL_NV_TEXTURE_ENV_COMBINE4
    Operand3AlphaNv = gl.Constants.GL_OPERAND3_ALPHA_NV, 
#endif

}

#endif
