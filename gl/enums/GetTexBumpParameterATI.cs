#if GL_ATI_ENVMAP_BUMPMAP

public enum GetTexBumpParameterATI : GLenum { 
#if GL_ATI_ENVMAP_BUMPMAP
    BumpRotMatrixAti = gl.Constants.GL_BUMP_ROT_MATRIX_ATI, 
#endif

#if GL_ATI_ENVMAP_BUMPMAP
    BumpRotMatrixSizeAti = gl.Constants.GL_BUMP_ROT_MATRIX_SIZE_ATI, 
#endif

#if GL_ATI_ENVMAP_BUMPMAP
    BumpNumTexUnitsAti = gl.Constants.GL_BUMP_NUM_TEX_UNITS_ATI, 
#endif

#if GL_ATI_ENVMAP_BUMPMAP
    BumpUnitsAti = gl.Constants.GL_BUMP_TEX_UNITS_ATI, 
#endif

}

#endif
