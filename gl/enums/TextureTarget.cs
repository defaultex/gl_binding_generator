#if (GL_ARB_INTERNALFORMAT_QUERY2 || GL_ES_VERSION_2_0 || GL_EXT_SPARSE_TEXTURE || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0 || GL_VERSION_1_3 || GL_ARB_FRAMEBUFFER_OBJECT || GL_NV_INTERNALFORMAT_SAMPLE_QUERY || GL_VERSION_3_0 || GL_ES_VERSION_3_0 || GL_VERSION_1_2 || GL_ARB_TEXTURE_MULTISAMPLE || GL_ES_VERSION_3_1 || GL_VERSION_3_2 || GL_ES_VERSION_3_2 || GL_VERSION_3_1 || GL_VERSION_4_0 || GL_VERSION_1_1 || GL_ARB_TEXTURE_CUBE_MAP || GL_ARB_TEXTURE_CUBE_MAP_ARRAY || GL_ARB_TEXTURE_RECTANGLE || GL_OES_TEXTURE_CUBE_MAP_ARRAY || GL_EXT_TEXTURE || GL_EXT_TEXTURE_ARRAY || GL_EXT_TEXTURE_CUBE_MAP || GL_EXT_TEXTURE_CUBE_MAP_ARRAY || GL_EXT_TEXTURE3D || GL_NV_TEXTURE_RECTANGLE || GL_OES_TEXTURE_3D || GL_OES_TEXTURE_CUBE_MAP || GL_SGIS_DETAIL_TEXTURE || GL_SGIS_TEXTURE4D)

public enum TextureTarget : GLenum { 
#if (GL_ARB_INTERNALFORMAT_QUERY2 || GL_ES_VERSION_2_0 || GL_EXT_SPARSE_TEXTURE || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    Texture2D = gl.Constants.GL_TEXTURE_2D, 
#endif

#if (GL_ARB_INTERNALFORMAT_QUERY2 || GL_ES_VERSION_2_0 || GL_EXT_SPARSE_TEXTURE || GL_VERSION_1_3)
    CubeMap = gl.Constants.GL_TEXTURE_CUBE_MAP, 
#endif

#if (GL_ES_VERSION_2_0 || GL_VERSION_1_3)
    CubeMapPositiveX = gl.Constants.GL_TEXTURE_CUBE_MAP_POSITIVE_X, 
#endif

#if (GL_ES_VERSION_2_0 || GL_VERSION_1_3)
    CubeMapNegativeX = gl.Constants.GL_TEXTURE_CUBE_MAP_NEGATIVE_X, 
#endif

#if (GL_ES_VERSION_2_0 || GL_VERSION_1_3)
    CubeMapPositiveY = gl.Constants.GL_TEXTURE_CUBE_MAP_POSITIVE_Y, 
#endif

#if (GL_ES_VERSION_2_0 || GL_VERSION_1_3)
    CubeMapNegativeY = gl.Constants.GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, 
#endif

#if (GL_ES_VERSION_2_0 || GL_VERSION_1_3)
    CubeMapPositiveZ = gl.Constants.GL_TEXTURE_CUBE_MAP_POSITIVE_Z, 
#endif

#if (GL_ES_VERSION_2_0 || GL_VERSION_1_3)
    CubeMapNegativeZ = gl.Constants.GL_TEXTURE_CUBE_MAP_NEGATIVE_Z, 
#endif

#if (GL_ARB_FRAMEBUFFER_OBJECT || GL_ARB_INTERNALFORMAT_QUERY2 || GL_ES_VERSION_2_0 || GL_NV_INTERNALFORMAT_SAMPLE_QUERY || GL_SC_VERSION_2_0 || GL_VERSION_3_0)
    Renderbuffer = gl.Constants.GL_RENDERBUFFER, 
#endif

#if (GL_ARB_INTERNALFORMAT_QUERY2 || GL_ES_VERSION_3_0 || GL_EXT_SPARSE_TEXTURE || GL_VERSION_1_2)
    Texture3D = gl.Constants.GL_TEXTURE_3D, 
#endif

#if (GL_ARB_INTERNALFORMAT_QUERY2 || GL_ES_VERSION_3_0 || GL_EXT_SPARSE_TEXTURE || GL_VERSION_3_0)
    Texture2DArray = gl.Constants.GL_TEXTURE_2D_ARRAY, 
#endif

#if (GL_ARB_INTERNALFORMAT_QUERY2 || GL_ARB_TEXTURE_MULTISAMPLE || GL_ES_VERSION_3_1 || GL_NV_INTERNALFORMAT_SAMPLE_QUERY || GL_VERSION_3_2)
    Texture2DMultisample = gl.Constants.GL_TEXTURE_2D_MULTISAMPLE, 
#endif

#if (GL_ARB_INTERNALFORMAT_QUERY2 || GL_ES_VERSION_3_2 || GL_VERSION_3_1)
    Buffer = gl.Constants.GL_TEXTURE_BUFFER, 
#endif

#if (GL_ARB_INTERNALFORMAT_QUERY2 || GL_ES_VERSION_3_2 || GL_VERSION_4_0)
    CubeMapArray = gl.Constants.GL_TEXTURE_CUBE_MAP_ARRAY, 
#endif

#if (GL_ARB_INTERNALFORMAT_QUERY2 || GL_ARB_TEXTURE_MULTISAMPLE || GL_ES_VERSION_3_2 || GL_NV_INTERNALFORMAT_SAMPLE_QUERY || GL_VERSION_3_2)
    Texture2DMultisampleArray = gl.Constants.GL_TEXTURE_2D_MULTISAMPLE_ARRAY, 
#endif

#if (GL_ARB_INTERNALFORMAT_QUERY2 || GL_VERSION_1_0)
    Texture1D = gl.Constants.GL_TEXTURE_1D, 
#endif

#if GL_VERSION_1_1
    ProxyTexture1D = gl.Constants.GL_PROXY_TEXTURE_1D, 
#endif

#if GL_VERSION_1_1
    ProxyTexture2D = gl.Constants.GL_PROXY_TEXTURE_2D, 
#endif

#if GL_VERSION_1_2
    ProxyTexture3D = gl.Constants.GL_PROXY_TEXTURE_3D, 
#endif

#if GL_VERSION_1_3
    ProxyTextureCubeMap = gl.Constants.GL_PROXY_TEXTURE_CUBE_MAP, 
#endif

#if (GL_ARB_INTERNALFORMAT_QUERY2 || GL_VERSION_3_0)
    Texture1DArray = gl.Constants.GL_TEXTURE_1D_ARRAY, 
#endif

#if GL_VERSION_3_0
    ProxyTexture1DArray = gl.Constants.GL_PROXY_TEXTURE_1D_ARRAY, 
#endif

#if GL_VERSION_3_0
    ProxyTexture2DArray = gl.Constants.GL_PROXY_TEXTURE_2D_ARRAY, 
#endif

#if (GL_ARB_INTERNALFORMAT_QUERY2 || GL_VERSION_3_1)
    Rectangle = gl.Constants.GL_TEXTURE_RECTANGLE, 
#endif

#if GL_VERSION_3_1
    ProxyTextureRectangle = gl.Constants.GL_PROXY_TEXTURE_RECTANGLE, 
#endif

#if (GL_ARB_TEXTURE_MULTISAMPLE || GL_VERSION_3_2)
    ProxyTexture2DMultisample = gl.Constants.GL_PROXY_TEXTURE_2D_MULTISAMPLE, 
#endif

#if (GL_ARB_TEXTURE_MULTISAMPLE || GL_VERSION_3_2)
    ProxyTexture2DMultisampleArray = gl.Constants.GL_PROXY_TEXTURE_2D_MULTISAMPLE_ARRAY, 
#endif

#if GL_VERSION_4_0
    ProxyTextureCubeMapArray = gl.Constants.GL_PROXY_TEXTURE_CUBE_MAP_ARRAY, 
#endif

#if GL_ARB_TEXTURE_CUBE_MAP
    CubeMapArb = gl.Constants.GL_TEXTURE_CUBE_MAP_ARB, 
#endif

#if GL_ARB_TEXTURE_CUBE_MAP
    ProxyTextureCubeMapArb = gl.Constants.GL_PROXY_TEXTURE_CUBE_MAP_ARB, 
#endif

#if GL_ARB_TEXTURE_CUBE_MAP_ARRAY
    CubeMapArrayArb = gl.Constants.GL_TEXTURE_CUBE_MAP_ARRAY_ARB, 
#endif

#if GL_ARB_TEXTURE_CUBE_MAP_ARRAY
    ProxyTextureCubeMapArrayArb = gl.Constants.GL_PROXY_TEXTURE_CUBE_MAP_ARRAY_ARB, 
#endif

#if GL_ARB_TEXTURE_RECTANGLE
    RectangleArb = gl.Constants.GL_TEXTURE_RECTANGLE_ARB, 
#endif

#if GL_ARB_TEXTURE_RECTANGLE
    ProxyTextureRectangleArb = gl.Constants.GL_PROXY_TEXTURE_RECTANGLE_ARB, 
#endif

#if (GL_EXT_SPARSE_TEXTURE || GL_OES_TEXTURE_CUBE_MAP_ARRAY)
    CubeMapArrayOes = gl.Constants.GL_TEXTURE_CUBE_MAP_ARRAY_OES, 
#endif

#if GL_EXT_TEXTURE
    ProxyTexture1DExt = gl.Constants.GL_PROXY_TEXTURE_1D_EXT, 
#endif

#if GL_EXT_TEXTURE
    ProxyTexture2DExt = gl.Constants.GL_PROXY_TEXTURE_2D_EXT, 
#endif

#if GL_EXT_TEXTURE_ARRAY
    ProxyTexture1DArrayExt = gl.Constants.GL_PROXY_TEXTURE_1D_ARRAY_EXT, 
#endif

#if GL_EXT_TEXTURE_ARRAY
    ProxyTexture2DArrayExt = gl.Constants.GL_PROXY_TEXTURE_2D_ARRAY_EXT, 
#endif

#if GL_EXT_TEXTURE_CUBE_MAP
    CubeMapExt = gl.Constants.GL_TEXTURE_CUBE_MAP_EXT, 
#endif

#if GL_EXT_TEXTURE_CUBE_MAP
    ProxyTextureCubeMapExt = gl.Constants.GL_PROXY_TEXTURE_CUBE_MAP_EXT, 
#endif

#if GL_EXT_TEXTURE_CUBE_MAP_ARRAY
    CubeMapArrayExt = gl.Constants.GL_TEXTURE_CUBE_MAP_ARRAY_EXT, 
#endif

#if GL_EXT_TEXTURE3D
    Texture3DExt = gl.Constants.GL_TEXTURE_3D_EXT, 
#endif

#if GL_EXT_TEXTURE3D
    ProxyTexture3DExt = gl.Constants.GL_PROXY_TEXTURE_3D_EXT, 
#endif

#if GL_NV_TEXTURE_RECTANGLE
    RectangleNv = gl.Constants.GL_TEXTURE_RECTANGLE_NV, 
#endif

#if GL_NV_TEXTURE_RECTANGLE
    ProxyTextureRectangleNv = gl.Constants.GL_PROXY_TEXTURE_RECTANGLE_NV, 
#endif

#if GL_OES_TEXTURE_3D
    Texture3DOes = gl.Constants.GL_TEXTURE_3D_OES, 
#endif

#if GL_OES_TEXTURE_CUBE_MAP
    CubeMapOes = gl.Constants.GL_TEXTURE_CUBE_MAP_OES, 
#endif

#if GL_SGIS_DETAIL_TEXTURE
    DetailTexture2DSgis = gl.Constants.GL_DETAIL_TEXTURE_2D_SGIS, 
#endif

#if GL_SGIS_TEXTURE4D
    Texture4dSgis = gl.Constants.GL_TEXTURE_4D_SGIS, 
#endif

#if GL_SGIS_TEXTURE4D
    ProxyTexture4dSgis = gl.Constants.GL_PROXY_TEXTURE_4D_SGIS, 
#endif

}

#endif
