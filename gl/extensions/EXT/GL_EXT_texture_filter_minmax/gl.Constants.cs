#if (GL_EXT_texture_filter_minmax && (!gl || !glcore || !gles2))
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_TEXTURE_REDUCTION_MODE_EXT = 0x9366;
        public const GLenum GL_WEIGHTED_AVERAGE_EXT = 0x9367;
    }
}
#endif