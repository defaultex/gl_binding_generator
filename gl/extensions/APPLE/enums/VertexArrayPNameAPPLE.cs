#if (GL_APPLE_TEXTURE_RANGE || GL_APPLE_VERTEX_ARRAY_RANGE)

public enum VertexArrayPNameAPPLE : GLenum { 
#if (GL_APPLE_TEXTURE_RANGE || GL_APPLE_VERTEX_ARRAY_RANGE)
    StorageCachedApple = gl.Constants.GL_STORAGE_CACHED_APPLE, 
#endif

#if (GL_APPLE_TEXTURE_RANGE || GL_APPLE_VERTEX_ARRAY_RANGE)
    StorageSharedApple = gl.Constants.GL_STORAGE_SHARED_APPLE, 
#endif

#if GL_APPLE_VERTEX_ARRAY_RANGE
    StorageClientApple = gl.Constants.GL_STORAGE_CLIENT_APPLE, 
#endif

}

#endif
