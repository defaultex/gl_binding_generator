#if (GL_EXT_texture_lod_bias && (GL_API || GLES1_API))
public partial class glext_ext { 
    public partial class Constants { 
        public const GLenum GL_MAX_TEXTURE_LOD_BIAS_EXT = 0x84FD;
        public const GLenum GL_TEXTURE_FILTER_CONTROL_EXT = 0x8500;
        public const GLenum GL_TEXTURE_LOD_BIAS_EXT = 0x8501;
    }
}
#endif