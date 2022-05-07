#if (GL_EXT_blend_equation_separate && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_BLEND_EQUATION_RGB_EXT = 0x8009;
        public const GLenum GL_BLEND_EQUATION_ALPHA_EXT = 0x883D;
    }
}
#endif