#if (GL_ARB_depth_buffer_float && (!gl || !glcore))
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_DEPTH_COMPONENT32F = 0x8CAC;
        public const GLenum GL_DEPTH32F_STENCIL8 = 0x8CAD;
        public const GLenum GL_FLOAT_32_UNSIGNED_INT_24_8_REV = 0x8DAD;
    }
}
#endif