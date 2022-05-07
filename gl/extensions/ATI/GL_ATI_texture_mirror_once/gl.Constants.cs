#if (GL_ATI_texture_mirror_once && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_MIRROR_CLAMP_ATI = 0x8742;
        public const GLenum GL_MIRROR_CLAMP_TO_EDGE_ATI = 0x8743;
    }
}
#endif