#if (GL_ARB_color_buffer_float && GL_API)
public partial class arb { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_RGBA_FLOAT_MODE_ARB = 0x8820;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_CLAMP_VERTEX_COLOR_ARB = 0x891A;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_CLAMP_FRAGMENT_COLOR_ARB = 0x891B;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_CLAMP_READ_COLOR_ARB = 0x891C;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_FIXED_ONLY_ARB = 0x891D;
#endif
    }
}
#endif