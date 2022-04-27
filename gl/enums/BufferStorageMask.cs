#if (GL_ARB_BUFFER_STORAGE || GL_ARB_MAP_BUFFER_RANGE || GL_ES_VERSION_3_0 || GL_EXT_BUFFER_STORAGE || GL_VERSION_3_0 || GL_VERSION_4_4 || GL_ARB_SPARSE_BUFFER || GL_EXT_MAP_BUFFER_RANGE || GL_NV_GPU_MULTICAST || GL_NVX_CROSS_PROCESS_INTEROP || GL_NVX_LINKED_GPU_MULTICAST)
[Flags]
public enum BufferStorageMask : GLbitfield { 
    None = 0,
#if (GL_ARB_BUFFER_STORAGE || GL_ARB_MAP_BUFFER_RANGE || GL_ES_VERSION_3_0 || GL_EXT_BUFFER_STORAGE || GL_VERSION_3_0 || GL_VERSION_4_4)
    MapRead = gl.Constants.GL_MAP_READ_BIT, 
#endif

#if (GL_ARB_BUFFER_STORAGE || GL_ARB_MAP_BUFFER_RANGE || GL_ES_VERSION_3_0 || GL_EXT_BUFFER_STORAGE || GL_VERSION_3_0 || GL_VERSION_4_4)
    MapWrite = gl.Constants.GL_MAP_WRITE_BIT, 
#endif

#if (GL_ARB_BUFFER_STORAGE || GL_VERSION_4_4)
    DynamicStorage = gl.Constants.GL_DYNAMIC_STORAGE_BIT, 
#endif

#if (GL_ARB_BUFFER_STORAGE || GL_VERSION_4_4)
    ClientStorage = gl.Constants.GL_CLIENT_STORAGE_BIT, 
#endif

#if (GL_ARB_BUFFER_STORAGE || GL_VERSION_4_4)
    MapPersistent = gl.Constants.GL_MAP_PERSISTENT_BIT, 
#endif

#if (GL_ARB_BUFFER_STORAGE || GL_VERSION_4_4)
    MapCoherent = gl.Constants.GL_MAP_COHERENT_BIT, 
#endif

#if GL_ARB_SPARSE_BUFFER
    SparseBitArb = gl.Constants.GL_SPARSE_STORAGE_BIT_ARB, 
#endif

#if GL_EXT_BUFFER_STORAGE
    DynamicBitExt = gl.Constants.GL_DYNAMIC_STORAGE_BIT_EXT, 
#endif

#if GL_EXT_BUFFER_STORAGE
    ClientBitExt = gl.Constants.GL_CLIENT_STORAGE_BIT_EXT, 
#endif

#if GL_EXT_BUFFER_STORAGE
    MapPersistentBitExt = gl.Constants.GL_MAP_PERSISTENT_BIT_EXT, 
#endif

#if GL_EXT_BUFFER_STORAGE
    MapCoherentBitExt = gl.Constants.GL_MAP_COHERENT_BIT_EXT, 
#endif

#if GL_EXT_MAP_BUFFER_RANGE
    MapReadBitExt = gl.Constants.GL_MAP_READ_BIT_EXT, 
#endif

#if GL_EXT_MAP_BUFFER_RANGE
    MapWriteBitExt = gl.Constants.GL_MAP_WRITE_BIT_EXT, 
#endif

#if GL_NV_GPU_MULTICAST
    PerGpuStorageBitNv = gl.Constants.GL_PER_GPU_STORAGE_BIT_NV, 
#endif

#if GL_NVX_CROSS_PROCESS_INTEROP
    ExternalBitNvx = gl.Constants.GL_EXTERNAL_STORAGE_BIT_NVX, 
#endif

#if GL_NVX_LINKED_GPU_MULTICAST
    LgpuSeparateStorageBitNvx = gl.Constants.GL_LGPU_SEPARATE_STORAGE_BIT_NVX, 
#endif

}

#endif
