#if (GL_EXT_texture_lod_bias && (GL_API || GLES1_API))
public partial class ext { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_TEXTURE_LOD_BIAS_EXT = 0x84FD;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_FILTER_CONTROL_EXT = 0x8500;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_LOD_BIAS_EXT = 0x8501;
#endif
    }
}
#endif