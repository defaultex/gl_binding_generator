#if (GL_SGIX_convolution_accuracy && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_CONVOLUTION_HINT_SGIX = 0x8316;
    }
}
#endif