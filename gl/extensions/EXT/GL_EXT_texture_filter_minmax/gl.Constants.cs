#if (GL_EXT_texture_filter_minmax && (GL_API || GLCORE_API || GLES2_API))
public partial class ext { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_REDUCTION_MODE_EXT = 0x9366;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_WEIGHTED_AVERAGE_EXT = 0x9367;
#endif
    }
}
#endif