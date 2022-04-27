#if (GL_VERSION_1_0 || GL_SGIX_POLYNOMIAL_FFD)

public enum MapTarget : GLenum { 
#if GL_VERSION_1_0
    Map1Color4 = gl.Constants.GL_MAP1_COLOR_4, 
#endif

#if GL_VERSION_1_0
    Map1Index = gl.Constants.GL_MAP1_INDEX, 
#endif

#if GL_VERSION_1_0
    Map1Normal = gl.Constants.GL_MAP1_NORMAL, 
#endif

#if GL_VERSION_1_0
    Map1TextureCoord1 = gl.Constants.GL_MAP1_TEXTURE_COORD_1, 
#endif

#if GL_VERSION_1_0
    Map1TextureCoord2 = gl.Constants.GL_MAP1_TEXTURE_COORD_2, 
#endif

#if GL_VERSION_1_0
    Map1TextureCoord3 = gl.Constants.GL_MAP1_TEXTURE_COORD_3, 
#endif

#if GL_VERSION_1_0
    Map1TextureCoord4 = gl.Constants.GL_MAP1_TEXTURE_COORD_4, 
#endif

#if GL_VERSION_1_0
    Map1Vertex3 = gl.Constants.GL_MAP1_VERTEX_3, 
#endif

#if GL_VERSION_1_0
    Map1Vertex4 = gl.Constants.GL_MAP1_VERTEX_4, 
#endif

#if GL_VERSION_1_0
    Map2Color4 = gl.Constants.GL_MAP2_COLOR_4, 
#endif

#if GL_VERSION_1_0
    Map2Index = gl.Constants.GL_MAP2_INDEX, 
#endif

#if GL_VERSION_1_0
    Map2Normal = gl.Constants.GL_MAP2_NORMAL, 
#endif

#if GL_VERSION_1_0
    Map2TextureCoord1 = gl.Constants.GL_MAP2_TEXTURE_COORD_1, 
#endif

#if GL_VERSION_1_0
    Map2TextureCoord2 = gl.Constants.GL_MAP2_TEXTURE_COORD_2, 
#endif

#if GL_VERSION_1_0
    Map2TextureCoord3 = gl.Constants.GL_MAP2_TEXTURE_COORD_3, 
#endif

#if GL_VERSION_1_0
    Map2TextureCoord4 = gl.Constants.GL_MAP2_TEXTURE_COORD_4, 
#endif

#if GL_VERSION_1_0
    Map2Vertex3 = gl.Constants.GL_MAP2_VERTEX_3, 
#endif

#if GL_VERSION_1_0
    Map2Vertex4 = gl.Constants.GL_MAP2_VERTEX_4, 
#endif

#if GL_SGIX_POLYNOMIAL_FFD
    GeometryDeformationSgix = gl.Constants.GL_GEOMETRY_DEFORMATION_SGIX, 
#endif

#if GL_SGIX_POLYNOMIAL_FFD
    TextureDeformationSgix = gl.Constants.GL_TEXTURE_DEFORMATION_SGIX, 
#endif

}

#endif
