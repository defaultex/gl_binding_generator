#if (GL_NV_half_float && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_HALF_FLOAT_NV = 0x140B;
    }
}
#endif