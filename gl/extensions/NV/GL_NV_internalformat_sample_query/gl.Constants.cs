#if (GL_NV_internalformat_sample_query && (GL_API || GLCORE_API || GLES2_API))
public partial class nv { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_RENDERBUFFER = 0x8D41;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_TEXTURE_2D_MULTISAMPLE = 0x9100;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_TEXTURE_2D_MULTISAMPLE_ARRAY = 0x9102;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MULTISAMPLES_NV = 0x9371;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SUPERSAMPLE_SCALE_X_NV = 0x9372;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SUPERSAMPLE_SCALE_Y_NV = 0x9373;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_CONFORMANT_NV = 0x9374;
#endif
    }
}
#endif