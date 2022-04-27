#if GL_EXT_VERTEX_SHADER

public enum GetVariantValueEXT : GLenum { 
#if GL_EXT_VERTEX_SHADER
    VariantValueExt = gl.Constants.GL_VARIANT_VALUE_EXT, 
#endif

#if GL_EXT_VERTEX_SHADER
    VariantDatatypeExt = gl.Constants.GL_VARIANT_DATATYPE_EXT, 
#endif

#if GL_EXT_VERTEX_SHADER
    VariantArrayStrideExt = gl.Constants.GL_VARIANT_ARRAY_STRIDE_EXT, 
#endif

#if GL_EXT_VERTEX_SHADER
    VariantArrayTypeExt = gl.Constants.GL_VARIANT_ARRAY_TYPE_EXT, 
#endif

}

#endif
