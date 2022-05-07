#if (GL_SUN_convolution_border_modes && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_WRAP_BORDER_SUN = 0x81D4;
    }
}
#endif