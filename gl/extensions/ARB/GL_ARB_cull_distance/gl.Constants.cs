#if (GL_ARB_cull_distance && (!gl || !glcore))
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_MAX_CULL_DISTANCES = 0x82F9;
        public const GLenum GL_MAX_COMBINED_CLIP_AND_CULL_DISTANCES = 0x82FA;
    }
}
#endif