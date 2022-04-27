#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_2_0 || GL_VERSION_1_5 || GL_ES_VERSION_3_0 || GL_VERSION_3_0 || GL_VERSION_3_3 || GL_ARB_VERTEX_ATTRIB_BINDING || GL_ES_VERSION_3_1 || GL_VERSION_4_3 || GL_EXT_GPU_SHADER4)

public enum VertexAttribPropertyARB : GLenum { 
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

#if (GL_ARB_VERTEX_ATTRIB_BINDING || GL_ES_VERSION_3_1 || GL_VERSION_4_3)
    Binding = gl.Constants.GL_VERTEX_ATTRIB_BINDING, 
#endif

#if (GL_ARB_VERTEX_ATTRIB_BINDING || GL_ES_VERSION_3_1 || GL_VERSION_4_3)
    RelativeOffset = gl.Constants.GL_VERTEX_ATTRIB_RELATIVE_OFFSET, 
#endif

#if GL_VERSION_4_3
    ArrayLong = gl.Constants.GL_VERTEX_ATTRIB_ARRAY_LONG, 
#endif

#if GL_EXT_GPU_SHADER4
    ArrayIntegerExt = gl.Constants.GL_VERTEX_ATTRIB_ARRAY_INTEGER_EXT, 
#endif

}

#endif
