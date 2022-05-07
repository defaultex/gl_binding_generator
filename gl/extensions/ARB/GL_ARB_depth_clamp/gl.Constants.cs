#if (GL_ARB_depth_clamp && (!gl || !glcore))
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_DEPTH_CLAMP = 0x864F;
    }
}
#endif