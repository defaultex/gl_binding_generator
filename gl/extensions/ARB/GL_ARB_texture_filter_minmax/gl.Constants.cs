#if (GL_ARB_texture_filter_minmax && (!gl || !glcore))
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_TEXTURE_REDUCTION_MODE_ARB = 0x9366;
        public const GLenum GL_WEIGHTED_AVERAGE_ARB = 0x9367;
    }
}
#endif