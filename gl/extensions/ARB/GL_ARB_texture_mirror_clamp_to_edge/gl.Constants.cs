#if (GL_ARB_texture_mirror_clamp_to_edge && (!gl || !glcore))
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_MIRROR_CLAMP_TO_EDGE = 0x8743;
    }
}
#endif