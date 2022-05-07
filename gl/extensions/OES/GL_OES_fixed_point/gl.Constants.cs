#if (GL_OES_fixed_point && (!gl || !gles1))
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_FIXED_OES = 0x140C;
    }
}
#endif