#if (GL_EXT_memory_object_win32 && (GL_API || GLES2_API))
public partial class ext { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_LUID_SIZE_EXT = 8;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_HANDLE_TYPE_OPAQUE_WIN32_EXT = 0x9587;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_HANDLE_TYPE_OPAQUE_WIN32_KMT_EXT = 0x9588;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_HANDLE_TYPE_D3D12_TILEPOOL_EXT = 0x9589;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_HANDLE_TYPE_D3D12_RESOURCE_EXT = 0x958A;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_HANDLE_TYPE_D3D11_IMAGE_EXT = 0x958B;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_HANDLE_TYPE_D3D11_IMAGE_KMT_EXT = 0x958C;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_DEVICE_LUID_EXT = 0x9599;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_DEVICE_NODE_MASK_EXT = 0x959A;
#endif
    }
}
#endif