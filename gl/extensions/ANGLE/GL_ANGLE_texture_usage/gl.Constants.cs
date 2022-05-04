#if (GL_ANGLE_texture_usage && GLES2_API)
public partial class angle { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_USAGE_ANGLE = 0x93A2;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_FRAMEBUFFER_ATTACHMENT_ANGLE = 0x93A3;
#endif
    }
}
#endif