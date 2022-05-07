#if (GL_ARB_sampler_objects && (!gl || !glcore))
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_SAMPLER_BINDING = 0x8919;
    }
}
#endif