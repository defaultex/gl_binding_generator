#if (GL_EXT_multisampled_compatibility && GLES2_API)
public partial class ext { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MULTISAMPLE_EXT = 0x809D;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SAMPLE_ALPHA_TO_ONE_EXT = 0x809F;
#endif
    }
}
#endif