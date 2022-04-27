#if (GL_VERSION_1_2 || GL_EXT_SEPARATE_SPECULAR_COLOR)

public enum LightModelColorControl : GLenum { 
#if GL_VERSION_1_2
    SingleColor = gl.Constants.GL_SINGLE_COLOR, 
#endif

#if GL_VERSION_1_2
    SeparateSpecularColor = gl.Constants.GL_SEPARATE_SPECULAR_COLOR, 
#endif

#if GL_EXT_SEPARATE_SPECULAR_COLOR
    SingleColorExt = gl.Constants.GL_SINGLE_COLOR_EXT, 
#endif

#if GL_EXT_SEPARATE_SPECULAR_COLOR
    SeparateSpecularExt = gl.Constants.GL_SEPARATE_SPECULAR_COLOR_EXT, 
#endif

}

#endif
