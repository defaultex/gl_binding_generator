#if (GL_ARB_half_float_pixel && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_HALF_FLOAT_ARB = 0x140B;
    }
}
#endif