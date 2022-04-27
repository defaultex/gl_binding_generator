#if (GL_ARB_TESSELLATION_SHADER || GL_ES_VERSION_3_2 || GL_VERSION_4_0)

public enum PatchParameterName : GLenum { 
#if (GL_ARB_TESSELLATION_SHADER || GL_ES_VERSION_3_2 || GL_VERSION_4_0)
    Vertices = gl.Constants.GL_PATCH_VERTICES, 
#endif

#if (GL_ARB_TESSELLATION_SHADER || GL_VERSION_4_0)
    DefaultInnerLevel = gl.Constants.GL_PATCH_DEFAULT_INNER_LEVEL, 
#endif

#if (GL_ARB_TESSELLATION_SHADER || GL_VERSION_4_0)
    DefaultOuterLevel = gl.Constants.GL_PATCH_DEFAULT_OUTER_LEVEL, 
#endif

}

#endif
