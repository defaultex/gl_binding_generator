#if (GL_OES_blend_func_separate && GLES1_API)
public partial class oes { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_BLEND_DST_RGB_OES = 0x80C8;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_BLEND_SRC_RGB_OES = 0x80C9;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_BLEND_DST_ALPHA_OES = 0x80CA;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_BLEND_SRC_ALPHA_OES = 0x80CB;
#endif
    }
}
#endif