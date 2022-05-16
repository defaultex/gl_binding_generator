partial class hgl {
    
    public static SyncStatus ClientWaitSync(this GLsync sync, ulong timeout) {
        unsafe { return gl.Functions.glClientWaitSync(sync, SyncObjectMask.SyncFlushCommands, timeout); }
    }

    public static void DeleteSync(this GLsync sync) {
        unsafe { gl.Functions.glDeleteSync(sync); }
    }

    public static GLsync FenceSync() {
        unsafe { return gl.Functions.glFenceSync(SyncCondition.SyncGpuCommandsComplete, SyncBehaviorFlags.None); }
    }

    public static void GetSync(this GLsync sync, SyncParameter pname, out int length, int[] values) {
        unsafe {
            fixed (GLint* pValues = values)
            fixed (GLsizei* pLength = &length) {
                gl.Functions.glGetSynciv(sync, pname, values.Length, pLength, pValues);
            }
        }
    }

    public static GLboolean IsSync(this GLsync sync) {
        unsafe { return gl.Functions.glIsSync(sync); }
    }

    public static void TextureBarrier() {
        unsafe { gl.Functions.glTextureBarrier(); }
    }

    public static void WaitSync(this GLsync sync) {
        unsafe { gl.Functions.glWaitSync(sync, SyncBehaviorFlags.None, 0); }
    }
}