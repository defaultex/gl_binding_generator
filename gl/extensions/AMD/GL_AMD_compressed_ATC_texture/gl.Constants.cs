#if (GL_AMD_compressed_ATC_texture && (GLES1_API || GLES2_API))
public partial class amd { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_ATC_RGBA_INTERPOLATED_ALPHA_AMD = 0x87EE;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_ATC_RGB_AMD = 0x8C92;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_ATC_RGBA_EXPLICIT_ALPHA_AMD = 0x8C93;
#endif
    }
}
#endif