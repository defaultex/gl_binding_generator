[Flags]
public enum BufferStorageMask : GLbitfield {
    MapRead = gl.Constants.GL_MAP_READ_BIT,
    MapWrite = gl.Constants.GL_MAP_WRITE_BIT,
    MapPersistent = gl.Constants.GL_MAP_PERSISTENT_BIT,
    MapCoherent = gl.Constants.GL_MAP_COHERENT_BIT,
    DynamicStorage = gl.Constants.GL_DYNAMIC_STORAGE_BIT,
    ClientStorage = gl.Constants.GL_CLIENT_STORAGE_BIT,
#if GL_ARB_sparse_buffer
    SparseStorageBitArb = gl.Constants.GL_SPARSE_STORAGE_BIT_ARB,
#endif
}
