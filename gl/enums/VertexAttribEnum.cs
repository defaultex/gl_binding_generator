#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_2_0 || GL_VERSION_1_5 || GL_ES_VERSION_3_0 || GL_VERSION_3_0 || GL_VERSION_3_3)

public enum VertexAttribEnum : GLenum { 
#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_2_0)
    ArrayEnabled = gl.Constants.GL_VERTEX_ATTRIB_ARRAY_ENABLED, 
#endif

#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_2_0)
    ArraySize = gl.Constants.GL_VERTEX_ATTRIB_ARRAY_SIZE, 
#endif

#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_2_0)
    ArrayStride = gl.Constants.GL_VERTEX_ATTRIB_ARRAY_STRIDE, 
#endif

#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_2_0)
    ArrayType = gl.Constants.GL_VERTEX_ATTRIB_ARRAY_TYPE, 
#endif

#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_2_0)
    CurrentVertexAttrib = gl.Constants.GL_CURRENT_VERTEX_ATTRIB, 
#endif

#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_2_0)
    ArrayNormalized = gl.Constants.GL_VERTEX_ATTRIB_ARRAY_NORMALIZED, 
#endif

#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_5)
    ArrayBufferBinding = gl.Constants.GL_VERTEX_ATTRIB_ARRAY_BUFFER_BINDING, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    ArrayInteger = gl.Constants.GL_VERTEX_ATTRIB_ARRAY_INTEGER, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_3_3)
    ArrayDivisor = gl.Constants.GL_VERTEX_ATTRIB_ARRAY_DIVISOR, 
#endif

}

#endif
