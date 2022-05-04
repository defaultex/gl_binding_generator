#if (GL_ANGLE_framebuffer_blit && GLES2_API)
public partial class angle { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_DRAW_FRAMEBUFFER_BINDING_ANGLE = 0x8CA6;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_READ_FRAMEBUFFER_ANGLE = 0x8CA8;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_DRAW_FRAMEBUFFER_ANGLE = 0x8CA9;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_READ_FRAMEBUFFER_BINDING_ANGLE = 0x8CAA;
#endif
    }
}
#endif