public enum CopyImageSubDataTarget : GLenum {
    Texture1D = gl.Constants.GL_TEXTURE_1D,
    Texture2D = gl.Constants.GL_TEXTURE_2D,
    Texture3D = gl.Constants.GL_TEXTURE_3D,
    TextureCubeMap = gl.Constants.GL_TEXTURE_CUBE_MAP,
    Texture1DArray = gl.Constants.GL_TEXTURE_1D_ARRAY,
    Texture2DArray = gl.Constants.GL_TEXTURE_2D_ARRAY,
    Renderbuffer = gl.Constants.GL_RENDERBUFFER,
    TextureRectangle = gl.Constants.GL_TEXTURE_RECTANGLE,
    Texture2DMultisample = gl.Constants.GL_TEXTURE_2D_MULTISAMPLE,
    Texture2DMultisampleArray = gl.Constants.GL_TEXTURE_2D_MULTISAMPLE_ARRAY,
    TextureCubeMapArray = gl.Constants.GL_TEXTURE_CUBE_MAP_ARRAY,
}
