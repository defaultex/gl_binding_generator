public enum SyncStatus : GLenum {
    AlreadySignaled = gl.Constants.GL_ALREADY_SIGNALED,
    TimeoutExpired = gl.Constants.GL_TIMEOUT_EXPIRED,
    ConditionSatisfied = gl.Constants.GL_CONDITION_SATISFIED,
    WaitFailed = gl.Constants.GL_WAIT_FAILED,
}
