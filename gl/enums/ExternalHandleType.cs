#if (GL_EXT_MEMORY_OBJECT_FD || GL_EXT_SEMAPHORE_FD || GL_EXT_MEMORY_OBJECT_WIN32 || GL_EXT_SEMAPHORE_WIN32)

public enum ExternalHandleType : GLenum { 
#if (GL_EXT_MEMORY_OBJECT_FD || GL_EXT_SEMAPHORE_FD)
    HandleTypeOpaqueFdExt = gl.Constants.GL_HANDLE_TYPE_OPAQUE_FD_EXT, 
#endif

#if (GL_EXT_MEMORY_OBJECT_WIN32 || GL_EXT_SEMAPHORE_WIN32)
    HandleTypeOpaqueWin32Ext = gl.Constants.GL_HANDLE_TYPE_OPAQUE_WIN32_EXT, 
#endif

#if (GL_EXT_MEMORY_OBJECT_WIN32 || GL_EXT_SEMAPHORE_WIN32)
    HandleTypeOpaqueWin32KmtExt = gl.Constants.GL_HANDLE_TYPE_OPAQUE_WIN32_KMT_EXT, 
#endif

#if GL_EXT_MEMORY_OBJECT_WIN32
    HandleTypeD3d12TilepoolExt = gl.Constants.GL_HANDLE_TYPE_D3D12_TILEPOOL_EXT, 
#endif

#if GL_EXT_MEMORY_OBJECT_WIN32
    HandleTypeD3d12ResourceExt = gl.Constants.GL_HANDLE_TYPE_D3D12_RESOURCE_EXT, 
#endif

#if GL_EXT_MEMORY_OBJECT_WIN32
    HandleTypeD3d11ImageExt = gl.Constants.GL_HANDLE_TYPE_D3D11_IMAGE_EXT, 
#endif

#if GL_EXT_MEMORY_OBJECT_WIN32
    HandleTypeD3d11ImageKmtExt = gl.Constants.GL_HANDLE_TYPE_D3D11_IMAGE_KMT_EXT, 
#endif

#if GL_EXT_SEMAPHORE_WIN32
    HandleTypeD3d12FenceExt = gl.Constants.GL_HANDLE_TYPE_D3D12_FENCE_EXT, 
#endif

}

#endif
