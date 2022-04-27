#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_2_0 || GL_ES_VERSION_3_0 || GL_VERSION_3_0 || GL_VERSION_3_3 || GL_ARB_VERTEX_ATTRIB_BINDING || GL_ES_VERSION_3_1 || GL_VERSION_4_3)

public enum VertexArrayPName : GLenum { 
#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_2_0)
    AttribArrayEnabled = gl.Constants.GL_VERTEX_ATTRIB_ARRAY_ENABLED, 
#endif

#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_2_0)
    AttribArraySize = gl.Constants.GL_VERTEX_ATTRIB_ARRAY_SIZE, 
#endif

#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_2_0)
    AttribArrayStride = gl.Constants.GL_VERTEX_ATTRIB_ARRAY_STRIDE, 
#endif

#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_2_0)
    AttribArrayType = gl.Constants.GL_VERTEX_ATTRIB_ARRAY_TYPE, 
#endif

#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_2_0)
    AttribArrayNormalized = gl.Constants.GL_VERTEX_ATTRIB_ARRAY_NORMALIZED, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    AttribArrayInteger = gl.Constants.GL_VERTEX_ATTRIB_ARRAY_INTEGER, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_3_3)
    AttribArrayDivisor = gl.Constants.GL_VERTEX_ATTRIB_ARRAY_DIVISOR, 
#endif

#if (GL_ARB_VERTEX_ATTRIB_BINDING || GL_ES_VERSION_3_1 || GL_VERSION_4_3)
    AttribRelativeOffset = gl.Constants.GL_VERTEX_ATTRIB_RELATIVE_OFFSET, 
#endif

#if GL_VERSION_4_3
    AttribArrayLong = gl.Constants.GL_VERTEX_ATTRIB_ARRAY_LONG, 
#endif

}

#endif
