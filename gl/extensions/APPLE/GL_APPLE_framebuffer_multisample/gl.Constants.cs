#if (GL_APPLE_framebuffer_multisample && (GLES1_API || GLES2_API))
public partial class apple { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_DRAW_FRAMEBUFFER_BINDING_APPLE = 0x8CA6;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_READ_FRAMEBUFFER_APPLE = 0x8CA8;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_DRAW_FRAMEBUFFER_APPLE = 0x8CA9;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_READ_FRAMEBUFFER_BINDING_APPLE = 0x8CAA;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_RENDERBUFFER_SAMPLES_APPLE = 0x8CAB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_FRAMEBUFFER_INCOMPLETE_MULTISAMPLE_APPLE = 0x8D56;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_SAMPLES_APPLE = 0x8D57;
#endif
    }
}
#endif