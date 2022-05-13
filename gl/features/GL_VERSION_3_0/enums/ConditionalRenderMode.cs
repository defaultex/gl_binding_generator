public enum ConditionalRenderMode : GLenum {
    QueryWait = gl.Constants.GL_QUERY_WAIT,
    QueryNoWait = gl.Constants.GL_QUERY_NO_WAIT,
    QueryByRegionWait = gl.Constants.GL_QUERY_BY_REGION_WAIT,
    QueryByRegionNoWait = gl.Constants.GL_QUERY_BY_REGION_NO_WAIT,
    QueryWaitInverted = gl.Constants.GL_QUERY_WAIT_INVERTED,
    QueryNoWaitInverted = gl.Constants.GL_QUERY_NO_WAIT_INVERTED,
    QueryByRegionWaitInverted = gl.Constants.GL_QUERY_BY_REGION_WAIT_INVERTED,
    QueryByRegionNoWaitInverted = gl.Constants.GL_QUERY_BY_REGION_NO_WAIT_INVERTED,
}
