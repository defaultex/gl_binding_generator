#if (GL_EXT_semaphore && (GL_API || GLES2_API))
public partial class ext { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_UUID_SIZE_EXT = 16;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_LAYOUT_DEPTH_READ_ONLY_STENCIL_ATTACHMENT_EXT = 0x9530;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_LAYOUT_DEPTH_ATTACHMENT_STENCIL_READ_ONLY_EXT = 0x9531;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_LAYOUT_GENERAL_EXT = 0x958D;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_LAYOUT_COLOR_ATTACHMENT_EXT = 0x958E;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_LAYOUT_DEPTH_STENCIL_ATTACHMENT_EXT = 0x958F;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_LAYOUT_DEPTH_STENCIL_READ_ONLY_EXT = 0x9590;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_LAYOUT_SHADER_READ_ONLY_EXT = 0x9591;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_LAYOUT_TRANSFER_SRC_EXT = 0x9592;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_LAYOUT_TRANSFER_DST_EXT = 0x9593;
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
    }
}
#endif