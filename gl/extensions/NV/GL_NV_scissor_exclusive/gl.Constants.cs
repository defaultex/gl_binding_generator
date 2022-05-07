#if (GL_NV_scissor_exclusive && (!gl || !glcore || !gles2))
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_SCISSOR_TEST_EXCLUSIVE_NV = 0x9555;
        public const GLenum GL_SCISSOR_BOX_EXCLUSIVE_NV = 0x9556;
    }
}
#endif