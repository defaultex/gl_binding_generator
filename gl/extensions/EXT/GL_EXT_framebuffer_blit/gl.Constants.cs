#if (GL_EXT_framebuffer_blit && GL_API)
public partial class ext { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_DRAW_FRAMEBUFFER_BINDING_EXT = 0x8CA6;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_READ_FRAMEBUFFER_EXT = 0x8CA8;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_DRAW_FRAMEBUFFER_EXT = 0x8CA9;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_READ_FRAMEBUFFER_BINDING_EXT = 0x8CAA;
#endif
    }
}
#endif