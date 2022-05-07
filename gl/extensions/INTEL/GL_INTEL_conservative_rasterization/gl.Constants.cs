#if (GL_INTEL_conservative_rasterization && (!gl || !glcore || !gles2))
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_CONSERVATIVE_RASTERIZATION_INTEL = 0x83FE;
    }
}
#endif