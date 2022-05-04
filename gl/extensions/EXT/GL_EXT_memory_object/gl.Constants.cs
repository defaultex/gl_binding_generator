#if (GL_EXT_memory_object && (GL_API || GLES2_API))
public partial class ext { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_UUID_SIZE_EXT = 16;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_TILING_EXT = 0x9580;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_DEDICATED_MEMORY_OBJECT_EXT = 0x9581;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_NUM_TILING_TYPES_EXT = 0x9582;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TILING_TYPES_EXT = 0x9583;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_OPTIMAL_TILING_EXT = 0x9584;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_LINEAR_TILING_EXT = 0x9585;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_NUM_DEVICE_UUIDS_EXT = 0x9596;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_DEVICE_UUID_EXT = 0x9597;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_DRIVER_UUID_EXT = 0x9598;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PROTECTED_MEMORY_OBJECT_EXT = 0x959B;
#endif
    }
}
#endif