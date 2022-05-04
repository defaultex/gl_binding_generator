#if (GL_EXT_blend_color && GL_API)
public partial class ext { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_CONSTANT_COLOR_EXT = 0x8001;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_ONE_MINUS_CONSTANT_COLOR_EXT = 0x8002;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_CONSTANT_ALPHA_EXT = 0x8003;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_ONE_MINUS_CONSTANT_ALPHA_EXT = 0x8004;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_BLEND_COLOR_EXT = 0x8005;
#endif
    }
}
#endif