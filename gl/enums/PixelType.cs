#if (GL_ES_VERSION_2_0 || GL_EXT_RENDER_SNORM || GL_OES_BYTE_COORDINATES || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0 || GL_ANGLE_DEPTH_TEXTURE || GL_OES_DEPTH_TEXTURE || GL_OES_ELEMENT_INDEX_UINT || GL_ARB_VERTEX_SHADER || GL_OES_TEXTURE_FLOAT || GL_VERSION_1_2 || GL_EXT_PACKED_PIXELS)

public enum PixelType : GLenum { 
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

#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_2 || GL_VERSION_ES_CM_1_0)
    UnsignedShort4444 = gl.Constants.GL_UNSIGNED_SHORT_4_4_4_4, 
#endif

#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_2 || GL_VERSION_ES_CM_1_0)
    UnsignedShort5551 = gl.Constants.GL_UNSIGNED_SHORT_5_5_5_1, 
#endif

#if GL_VERSION_1_0
    Bitmap = gl.Constants.GL_BITMAP, 
#endif

#if GL_VERSION_1_2
    UnsignedByte332 = gl.Constants.GL_UNSIGNED_BYTE_3_3_2, 
#endif

#if GL_VERSION_1_2
    UnsignedInt8888 = gl.Constants.GL_UNSIGNED_INT_8_8_8_8, 
#endif

#if GL_VERSION_1_2
    UnsignedInt1010102 = gl.Constants.GL_UNSIGNED_INT_10_10_10_2, 
#endif

#if GL_EXT_PACKED_PIXELS
    UnsignedByte332Ext = gl.Constants.GL_UNSIGNED_BYTE_3_3_2_EXT, 
#endif

#if GL_EXT_PACKED_PIXELS
    UnsignedShort4444Ext = gl.Constants.GL_UNSIGNED_SHORT_4_4_4_4_EXT, 
#endif

#if GL_EXT_PACKED_PIXELS
    UnsignedShort5551Ext = gl.Constants.GL_UNSIGNED_SHORT_5_5_5_1_EXT, 
#endif

#if GL_EXT_PACKED_PIXELS
    UnsignedInt8888Ext = gl.Constants.GL_UNSIGNED_INT_8_8_8_8_EXT, 
#endif

#if GL_EXT_PACKED_PIXELS
    UnsignedInt1010102Ext = gl.Constants.GL_UNSIGNED_INT_10_10_10_2_EXT, 
#endif

}

#endif
