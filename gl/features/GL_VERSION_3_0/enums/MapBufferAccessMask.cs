[Flags]
public enum MapBufferAccessMask : GLbitfield {
    MapRead = gl.Constants.GL_MAP_READ_BIT,
    MapWrite = gl.Constants.GL_MAP_WRITE_BIT,
    MapInvalidateRange = gl.Constants.GL_MAP_INVALIDATE_RANGE_BIT,
    MapInvalidateBuffer = gl.Constants.GL_MAP_INVALIDATE_BUFFER_BIT,
    MapFlushExplicit = gl.Constants.GL_MAP_FLUSH_EXPLICIT_BIT,
    MapUnsynchronized = gl.Constants.GL_MAP_UNSYNCHRONIZED_BIT,
    MapPersistent = gl.Constants.GL_MAP_PERSISTENT_BIT,
    MapCoherent = gl.Constants.GL_MAP_COHERENT_BIT,
}
