#if (GL_APPLE_sync && (GLES1_API || GLES2_API))
public partial class apple { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TIMEOUT_IGNORED_APPLE = 0xFFFFFFFFFFFFFFFF;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SYNC_FLUSH_COMMANDS_BIT_APPLE = 0x00000001;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SYNC_OBJECT_APPLE = 0x8A53;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_SERVER_WAIT_TIMEOUT_APPLE = 0x9111;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_OBJECT_TYPE_APPLE = 0x9112;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SYNC_CONDITION_APPLE = 0x9113;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SYNC_STATUS_APPLE = 0x9114;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SYNC_FLAGS_APPLE = 0x9115;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SYNC_FENCE_APPLE = 0x9116;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SYNC_GPU_COMMANDS_COMPLETE_APPLE = 0x9117;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_UNSIGNALED_APPLE = 0x9118;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SIGNALED_APPLE = 0x9119;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_ALREADY_SIGNALED_APPLE = 0x911A;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TIMEOUT_EXPIRED_APPLE = 0x911B;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_CONDITION_SATISFIED_APPLE = 0x911C;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_WAIT_FAILED_APPLE = 0x911D;
#endif
    }
}
#endif