#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_2_0 || GL_ARB_VERTEX_PROGRAM || GL_ARB_VERTEX_SHADER)

public enum VertexAttribPointerPropertyARB : GLenum { 
#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_2_0)
    ArrayPointer = gl.Constants.GL_VERTEX_ATTRIB_ARRAY_POINTER, 
#endif

#if (GL_ARB_VERTEX_PROGRAM || GL_ARB_VERTEX_SHADER)
    ArrayPointerArb = gl.Constants.GL_VERTEX_ATTRIB_ARRAY_POINTER_ARB, 
#endif

}

#endif
