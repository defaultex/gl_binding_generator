#if (GL_ARB_ES3_1_compatibility && (!gl || !glcore))
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_BACK = 0x0405;
    }
}
#endif