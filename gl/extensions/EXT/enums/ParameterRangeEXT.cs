#if GL_EXT_VERTEX_SHADER

public enum ParameterRangeEXT : GLenum { 
#if GL_EXT_VERTEX_SHADER
    NormalizedExt = gl.Constants.GL_NORMALIZED_RANGE_EXT, 
#endif

#if GL_EXT_VERTEX_SHADER
    FullExt = gl.Constants.GL_FULL_RANGE_EXT, 
#endif

}

#endif
