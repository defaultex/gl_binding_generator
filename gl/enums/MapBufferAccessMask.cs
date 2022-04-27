#if (GL_ARB_BUFFER_STORAGE || GL_ARB_MAP_BUFFER_RANGE || GL_ES_VERSION_3_0 || GL_EXT_BUFFER_STORAGE || GL_VERSION_3_0 || GL_VERSION_4_4 || GL_EXT_MAP_BUFFER_RANGE)
[Flags]
public enum MapBufferAccessMask : GLbitfield { 
    None = 0,
#if (GL_ARB_BUFFER_STORAGE || GL_ARB_MAP_BUFFER_RANGE || GL_ES_VERSION_3_0 || GL_EXT_BUFFER_STORAGE || GL_VERSION_3_0 || GL_VERSION_4_4)
    Read = gl.Constants.GL_MAP_READ_BIT, 
#endif

#if (GL_ARB_BUFFER_STORAGE || GL_ARB_MAP_BUFFER_RANGE || GL_ES_VERSION_3_0 || GL_EXT_BUFFER_STORAGE || GL_VERSION_3_0 || GL_VERSION_4_4)
    Write = gl.Constants.GL_MAP_WRITE_BIT, 
#endif

#if (GL_ARB_MAP_BUFFER_RANGE || GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    InvalidateRange = gl.Constants.GL_MAP_INVALIDATE_RANGE_BIT, 
#endif

#if (GL_ARB_MAP_BUFFER_RANGE || GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    InvalidateBuffer = gl.Constants.GL_MAP_INVALIDATE_BUFFER_BIT, 
#endif

#if (GL_ARB_MAP_BUFFER_RANGE || GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    FlushExplicit = gl.Constants.GL_MAP_FLUSH_EXPLICIT_BIT, 
#endif

#if (GL_ARB_MAP_BUFFER_RANGE || GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    Unsynchronized = gl.Constants.GL_MAP_UNSYNCHRONIZED_BIT, 
#endif

#if (GL_ARB_BUFFER_STORAGE || GL_VERSION_4_4)
    Persistent = gl.Constants.GL_MAP_PERSISTENT_BIT, 
#endif

#if (GL_ARB_BUFFER_STORAGE || GL_VERSION_4_4)
    Coherent = gl.Constants.GL_MAP_COHERENT_BIT, 
#endif

#if GL_EXT_BUFFER_STORAGE
    PersistentBitExt = gl.Constants.GL_MAP_PERSISTENT_BIT_EXT, 
#endif

#if GL_EXT_BUFFER_STORAGE
    CoherentBitExt = gl.Constants.GL_MAP_COHERENT_BIT_EXT, 
#endif

#if GL_EXT_MAP_BUFFER_RANGE
    ReadBitExt = gl.Constants.GL_MAP_READ_BIT_EXT, 
#endif

#if GL_EXT_MAP_BUFFER_RANGE
    WriteBitExt = gl.Constants.GL_MAP_WRITE_BIT_EXT, 
#endif

#if GL_EXT_MAP_BUFFER_RANGE
    InvalidateRangeBitExt = gl.Constants.GL_MAP_INVALIDATE_RANGE_BIT_EXT, 
#endif

#if GL_EXT_MAP_BUFFER_RANGE
    InvalidateBufferBitExt = gl.Constants.GL_MAP_INVALIDATE_BUFFER_BIT_EXT, 
#endif

#if GL_EXT_MAP_BUFFER_RANGE
    FlushExplicitBitExt = gl.Constants.GL_MAP_FLUSH_EXPLICIT_BIT_EXT, 
#endif

#if GL_EXT_MAP_BUFFER_RANGE
    UnsynchronizedBitExt = gl.Constants.GL_MAP_UNSYNCHRONIZED_BIT_EXT, 
#endif

}

#endif
