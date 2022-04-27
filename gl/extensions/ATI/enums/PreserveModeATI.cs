#if GL_ATI_VERTEX_ARRAY_OBJECT

public enum PreserveModeATI : GLenum { 
#if GL_ATI_VERTEX_ARRAY_OBJECT
    Ati = gl.Constants.GL_PRESERVE_ATI, 
#endif

#if GL_ATI_VERTEX_ARRAY_OBJECT
    DiscardAti = gl.Constants.GL_DISCARD_ATI, 
#endif

}

#endif
