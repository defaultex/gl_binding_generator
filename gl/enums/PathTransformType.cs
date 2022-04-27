#if (GL_ES_VERSION_2_0 || GL_KHR_CONTEXT_FLUSH_CONTROL || GL_NV_REGISTER_COMBINERS || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_4_5 || GL_VERSION_4_6 || GL_NV_PATH_RENDERING)

public enum PathTransformType : GLenum { 
#if (GL_ES_VERSION_2_0 || GL_KHR_CONTEXT_FLUSH_CONTROL || GL_NV_REGISTER_COMBINERS || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_4_5 || GL_VERSION_4_6)
    None = gl.Constants.GL_NONE, 
#endif

#if GL_NV_PATH_RENDERING
    TranslateXNv = gl.Constants.GL_TRANSLATE_X_NV, 
#endif

#if GL_NV_PATH_RENDERING
    TranslateYNv = gl.Constants.GL_TRANSLATE_Y_NV, 
#endif

#if GL_NV_PATH_RENDERING
    Translate2DNv = gl.Constants.GL_TRANSLATE_2D_NV, 
#endif

#if GL_NV_PATH_RENDERING
    Translate3DNv = gl.Constants.GL_TRANSLATE_3D_NV, 
#endif

#if GL_NV_PATH_RENDERING
    Affine2DNv = gl.Constants.GL_AFFINE_2D_NV, 
#endif

#if GL_NV_PATH_RENDERING
    Affine3DNv = gl.Constants.GL_AFFINE_3D_NV, 
#endif

#if GL_NV_PATH_RENDERING
    TransposeAffine2DNv = gl.Constants.GL_TRANSPOSE_AFFINE_2D_NV, 
#endif

#if GL_NV_PATH_RENDERING
    TransposeAffine3DNv = gl.Constants.GL_TRANSPOSE_AFFINE_3D_NV, 
#endif

}

#endif
