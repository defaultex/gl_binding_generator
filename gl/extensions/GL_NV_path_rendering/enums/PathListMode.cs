#if GL_NV_path_rendering

public enum PathListMode : GLenum {
#if GL_NV_path_rendering
    AccumAdjacentPairsNv = gl.Constants.GL_ACCUM_ADJACENT_PAIRS_NV,
#endif

#if GL_NV_path_rendering
    AdjacentPairsNv = gl.Constants.GL_ADJACENT_PAIRS_NV,
#endif

#if GL_NV_path_rendering
    FirstToRestNv = gl.Constants.GL_FIRST_TO_REST_NV,
#endif
}

#endif