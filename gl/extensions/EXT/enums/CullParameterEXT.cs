#if GL_EXT_CULL_VERTEX

public enum CullParameterEXT : GLenum { 
#if GL_EXT_CULL_VERTEX
    VertexEyePositionExt = gl.Constants.GL_CULL_VERTEX_EYE_POSITION_EXT, 
#endif

#if GL_EXT_CULL_VERTEX
    VertexObjectPositionExt = gl.Constants.GL_CULL_VERTEX_OBJECT_POSITION_EXT, 
#endif

}

#endif
