#if (GL_EXT_color_buffer_half_float && GLES2_API)
public partial class ext { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_FRAMEBUFFER_ATTACHMENT_COMPONENT_TYPE_EXT = 0x8211;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_R16F_EXT = 0x822D;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_RG16F_EXT = 0x822F;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_RGBA16F_EXT = 0x881A;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_RGB16F_EXT = 0x881B;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_UNSIGNED_NORMALIZED_EXT = 0x8C17;
#endif
    }
}
#endif