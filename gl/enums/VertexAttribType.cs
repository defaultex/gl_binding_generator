#if (GL_ES_VERSION_2_0 || GL_EXT_RENDER_SNORM || GL_OES_BYTE_COORDINATES || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0 || GL_ANGLE_DEPTH_TEXTURE || GL_OES_DEPTH_TEXTURE || GL_OES_ELEMENT_INDEX_UINT || GL_ARB_VERTEX_SHADER || GL_OES_TEXTURE_FLOAT || GL_ARB_ES2_COMPATIBILITY || GL_VERSION_4_1 || GL_ARB_HALF_FLOAT_VERTEX || GL_ES_VERSION_3_0 || GL_VERSION_3_0 || GL_ARB_VERTEX_TYPE_2_10_10_10_REV || GL_VERSION_1_2 || GL_ARB_VERTEX_TYPE_10F_11F_11F_REV || GL_VERSION_4_4 || GL_VERSION_3_3 || GL_ARB_GPU_SHADER_FP64 || GL_EXT_VERTEX_ATTRIB_64BIT || GL_VERSION_1_1)

public enum VertexAttribType : GLenum { 
#if (GL_ES_VERSION_2_0 || GL_EXT_RENDER_SNORM || GL_OES_BYTE_COORDINATES || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    Byte = gl.Constants.GL_BYTE, 
#endif

#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    UnsignedByte = gl.Constants.GL_UNSIGNED_BYTE, 
#endif

#if (GL_ES_VERSION_2_0 || GL_EXT_RENDER_SNORM || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    Short = gl.Constants.GL_SHORT, 
#endif

#if (GL_ANGLE_DEPTH_TEXTURE || GL_ES_VERSION_2_0 || GL_OES_DEPTH_TEXTURE || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    UnsignedShort = gl.Constants.GL_UNSIGNED_SHORT, 
#endif

#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_0)
    Int = gl.Constants.GL_INT, 
#endif

#if (GL_ANGLE_DEPTH_TEXTURE || GL_ES_VERSION_2_0 || GL_OES_DEPTH_TEXTURE || GL_OES_ELEMENT_INDEX_UINT || GL_SC_VERSION_2_0 || GL_VERSION_1_0)
    UnsignedInt = gl.Constants.GL_UNSIGNED_INT, 
#endif

#if (GL_ARB_VERTEX_SHADER || GL_ES_VERSION_2_0 || GL_OES_TEXTURE_FLOAT || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    Float = gl.Constants.GL_FLOAT, 
#endif

#if (GL_ARB_ES2_COMPATIBILITY || GL_ES_VERSION_2_0 || GL_VERSION_4_1 || GL_VERSION_ES_CM_1_0)
    Fixed = gl.Constants.GL_FIXED, 
#endif

#if (GL_ARB_HALF_FLOAT_VERTEX || GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    HalfFloat = gl.Constants.GL_HALF_FLOAT, 
#endif

#if (GL_ARB_VERTEX_TYPE_2_10_10_10_REV || GL_ES_VERSION_3_0 || GL_VERSION_1_2)
    UnsignedInt2101010Rev = gl.Constants.GL_UNSIGNED_INT_2_10_10_10_REV, 
#endif

#if (GL_ARB_VERTEX_TYPE_10F_11F_11F_REV || GL_ES_VERSION_3_0 || GL_VERSION_3_0 || GL_VERSION_4_4)
    UnsignedInt10f11f11fRev = gl.Constants.GL_UNSIGNED_INT_10F_11F_11F_REV, 
#endif

#if (GL_ARB_VERTEX_TYPE_2_10_10_10_REV || GL_ES_VERSION_3_0 || GL_VERSION_3_3)
    Int2101010Rev = gl.Constants.GL_INT_2_10_10_10_REV, 
#endif

#if (GL_ARB_GPU_SHADER_FP64 || GL_EXT_VERTEX_ATTRIB_64BIT || GL_VERSION_1_1)
    Double = gl.Constants.GL_DOUBLE, 
#endif

}

#endif
