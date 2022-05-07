#if (GL_NV_representative_fragment_test && (!gl || !glcore || !gles2))
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_REPRESENTATIVE_FRAGMENT_TEST_NV = 0x937F;
    }
}
#endif