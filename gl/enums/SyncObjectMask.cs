#if (GL_ARB_SYNC || GL_ES_VERSION_3_0 || GL_VERSION_3_2 || GL_APPLE_SYNC)
[Flags]
public enum SyncObjectMask : GLbitfield { 
    None = 0,
#if (GL_ARB_SYNC || GL_ES_VERSION_3_0 || GL_VERSION_3_2)
    FlushCommands = gl.Constants.GL_SYNC_FLUSH_COMMANDS_BIT, 
#endif

#if GL_APPLE_SYNC
    FlushCommandsBitApple = gl.Constants.GL_SYNC_FLUSH_COMMANDS_BIT_APPLE, 
#endif

}

#endif
