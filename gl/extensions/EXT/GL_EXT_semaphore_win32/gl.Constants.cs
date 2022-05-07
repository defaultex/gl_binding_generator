#if (GL_EXT_semaphore_win32 && (!gl || !gles2))
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_LUID_SIZE_EXT = 8;
        public const GLenum GL_HANDLE_TYPE_OPAQUE_WIN32_EXT = 0x9587;
        public const GLenum GL_HANDLE_TYPE_OPAQUE_WIN32_KMT_EXT = 0x9588;
        public const GLenum GL_HANDLE_TYPE_D3D12_FENCE_EXT = 0x9594;
        public const GLenum GL_D3D12_FENCE_VALUE_EXT = 0x9595;
        public const GLenum GL_DEVICE_LUID_EXT = 0x9599;
        public const GLenum GL_DEVICE_NODE_MASK_EXT = 0x959A;
    }
}
#endif