public enum TextureTarget : GLenum {
    Texture1D = gl.Constants.GL_TEXTURE_1D,
    Texture2D = gl.Constants.GL_TEXTURE_2D,
    ProxyTexture1D = gl.Constants.GL_PROXY_TEXTURE_1D,
    ProxyTexture2D = gl.Constants.GL_PROXY_TEXTURE_2D,
    Texture3D = gl.Constants.GL_TEXTURE_3D,
    ProxyTexture3D = gl.Constants.GL_PROXY_TEXTURE_3D,
    TextureCubeMap = gl.Constants.GL_TEXTURE_CUBE_MAP,
    TextureCubeMapPositiveX = gl.Constants.GL_TEXTURE_CUBE_MAP_POSITIVE_X,
    TextureCubeMapNegativeX = gl.Constants.GL_TEXTURE_CUBE_MAP_NEGATIVE_X,
    TextureCubeMapPositiveY = gl.Constants.GL_TEXTURE_CUBE_MAP_POSITIVE_Y,
    TextureCubeMapNegativeY = gl.Constants.GL_TEXTURE_CUBE_MAP_NEGATIVE_Y,
    TextureCubeMapPositiveZ = gl.Constants.GL_TEXTURE_CUBE_MAP_POSITIVE_Z,
    TextureCubeMapNegativeZ = gl.Constants.GL_TEXTURE_CUBE_MAP_NEGATIVE_Z,
    ProxyTextureCubeMap = gl.Constants.GL_PROXY_TEXTURE_CUBE_MAP,
    Texture1DArray = gl.Constants.GL_TEXTURE_1D_ARRAY,
    ProxyTexture1DArray = gl.Constants.GL_PROXY_TEXTURE_1D_ARRAY,
    Texture2DArray = gl.Constants.GL_TEXTURE_2D_ARRAY,
    ProxyTexture2DArray = gl.Constants.GL_PROXY_TEXTURE_2D_ARRAY,
    Renderbuffer = gl.Constants.GL_RENDERBUFFER,
    TextureBuffer = gl.Constants.GL_TEXTURE_BUFFER,
    TextureRectangle = gl.Constants.GL_TEXTURE_RECTANGLE,
    ProxyTextureRectangle = gl.Constants.GL_PROXY_TEXTURE_RECTANGLE,
    Texture2DMultisample = gl.Constants.GL_TEXTURE_2D_MULTISAMPLE,
    ProxyTexture2DMultisample = gl.Constants.GL_PROXY_TEXTURE_2D_MULTISAMPLE,
    Texture2DMultisampleArray = gl.Constants.GL_TEXTURE_2D_MULTISAMPLE_ARRAY,
    ProxyTexture2DMultisampleArray = gl.Constants.GL_PROXY_TEXTURE_2D_MULTISAMPLE_ARRAY,
    TextureCubeMapArray = gl.Constants.GL_TEXTURE_CUBE_MAP_ARRAY,
    ProxyTextureCubeMapArray = gl.Constants.GL_PROXY_TEXTURE_CUBE_MAP_ARRAY,
#if GL_ARB_texture_cube_map_array
    TextureCubeMapArrayArb = gl.Constants.GL_TEXTURE_CUBE_MAP_ARRAY_ARB,
#endif

#if GL_ARB_texture_cube_map_array
    ProxyTextureCubeMapArrayArb = gl.Constants.GL_PROXY_TEXTURE_CUBE_MAP_ARRAY_ARB,
#endif
}
