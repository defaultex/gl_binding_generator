#if (GL_ARB_shadow && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_TEXTURE_COMPARE_MODE_ARB = 0x884C;
        public const GLenum GL_TEXTURE_COMPARE_FUNC_ARB = 0x884D;
        public const GLenum GL_COMPARE_R_TO_TEXTURE_ARB = 0x884E;
    }
}
#endif