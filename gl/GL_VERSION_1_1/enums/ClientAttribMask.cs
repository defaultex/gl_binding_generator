#if GL_VERSION_1_1
[Flags]
public enum ClientAttribMask : GLbitfield { 
    None = 0,
#if GL_VERSION_1_1
    PixelStore = gl.Constants.GL_CLIENT_PIXEL_STORE_BIT, 
#endif

#if GL_VERSION_1_1
    VertexArray = gl.Constants.GL_CLIENT_VERTEX_ARRAY_BIT, 
#endif

#if GL_VERSION_1_1
    AllAttrib = gl.Constants.GL_CLIENT_ALL_ATTRIB_BITS, 
#endif

}

#endif
