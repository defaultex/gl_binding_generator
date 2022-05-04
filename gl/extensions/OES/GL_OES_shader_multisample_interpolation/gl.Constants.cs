#if (GL_OES_shader_multisample_interpolation && GLES2_API)
public partial class oes { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MIN_FRAGMENT_INTERPOLATION_OFFSET_OES = 0x8E5B;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_FRAGMENT_INTERPOLATION_OFFSET_OES = 0x8E5C;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_FRAGMENT_INTERPOLATION_OFFSET_BITS_OES = 0x8E5D;
#endif
    }
}
#endif