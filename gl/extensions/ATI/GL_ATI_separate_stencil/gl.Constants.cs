#if (GL_ATI_separate_stencil && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_STENCIL_BACK_FUNC_ATI = 0x8800;
        public const GLenum GL_STENCIL_BACK_FAIL_ATI = 0x8801;
        public const GLenum GL_STENCIL_BACK_PASS_DEPTH_FAIL_ATI = 0x8802;
        public const GLenum GL_STENCIL_BACK_PASS_DEPTH_PASS_ATI = 0x8803;
    }
}
#endif