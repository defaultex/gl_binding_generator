#if GL_ATI_VERTEX_ARRAY_OBJECT

public enum ArrayObjectUsageATI : GLenum { 
#if GL_ATI_VERTEX_ARRAY_OBJECT
    StaticAti = gl.Constants.GL_STATIC_ATI, 
#endif

#if GL_ATI_VERTEX_ARRAY_OBJECT
    DynamicAti = gl.Constants.GL_DYNAMIC_ATI, 
#endif

}

#endif
