#if (GL_NV_depth_clamp && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_DEPTH_CLAMP_NV = 0x864F;
    }
}
#endif