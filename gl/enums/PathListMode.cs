#if GL_NV_PATH_RENDERING

public enum PathListMode : GLenum { 
#if GL_NV_PATH_RENDERING
    AccumAdjacentPairsNv = gl.Constants.GL_ACCUM_ADJACENT_PAIRS_NV, 
#endif

#if GL_NV_PATH_RENDERING
    AdjacentPairsNv = gl.Constants.GL_ADJACENT_PAIRS_NV, 
#endif

#if GL_NV_PATH_RENDERING
    FirstToRestNv = gl.Constants.GL_FIRST_TO_REST_NV, 
#endif

}

#endif
