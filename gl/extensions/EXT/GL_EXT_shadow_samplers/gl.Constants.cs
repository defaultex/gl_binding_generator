#if (GL_EXT_shadow_samplers && GLES2_API)
public partial class ext { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_COMPARE_MODE_EXT = 0x884C;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_COMPARE_FUNC_EXT = 0x884D;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_COMPARE_REF_TO_TEXTURE_EXT = 0x884E;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SAMPLER_2D_SHADOW_EXT = 0x8B62;
#endif
    }
}
#endif