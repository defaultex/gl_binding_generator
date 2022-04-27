#if (GL_ARB_PROVOKING_VERTEX || GL_ARB_VIEWPORT_ARRAY || GL_ES_VERSION_3_2 || GL_VERSION_3_2)

public enum VertexProvokingMode : GLenum { 
#if (GL_ARB_PROVOKING_VERTEX || GL_ARB_VIEWPORT_ARRAY || GL_ES_VERSION_3_2 || GL_VERSION_3_2)
    FirstVertexConvention = gl.Constants.GL_FIRST_VERTEX_CONVENTION, 
#endif

#if (GL_ARB_PROVOKING_VERTEX || GL_ARB_VIEWPORT_ARRAY || GL_ES_VERSION_3_2 || GL_VERSION_3_2)
    LastVertexConvention = gl.Constants.GL_LAST_VERTEX_CONVENTION, 
#endif

}

#endif
