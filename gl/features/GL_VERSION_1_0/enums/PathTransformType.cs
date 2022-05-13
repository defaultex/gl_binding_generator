public enum PathTransformType : GLenum {
    None = gl.Constants.GL_NONE,
#if GL_NV_path_rendering
    TranslateXNv = gl.Constants.GL_TRANSLATE_X_NV,
#endif

#if GL_NV_path_rendering
    TranslateYNv = gl.Constants.GL_TRANSLATE_Y_NV,
#endif

#if GL_NV_path_rendering
    Translate2DNv = gl.Constants.GL_TRANSLATE_2D_NV,
#endif

#if GL_NV_path_rendering
    Translate3DNv = gl.Constants.GL_TRANSLATE_3D_NV,
#endif

#if GL_NV_path_rendering
    Affine2DNv = gl.Constants.GL_AFFINE_2D_NV,
#endif

#if GL_NV_path_rendering
    Affine3DNv = gl.Constants.GL_AFFINE_3D_NV,
#endif

#if GL_NV_path_rendering
    TransposeAffine2DNv = gl.Constants.GL_TRANSPOSE_AFFINE_2D_NV,
#endif

#if GL_NV_path_rendering
    TransposeAffine3DNv = gl.Constants.GL_TRANSPOSE_AFFINE_3D_NV,
#endif
}
