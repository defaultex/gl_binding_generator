#if (GL_EXT_texture_mirror_clamp && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_MIRROR_CLAMP_EXT = 0x8742;
        public const GLenum GL_MIRROR_CLAMP_TO_EDGE_EXT = 0x8743;
        public const GLenum GL_MIRROR_CLAMP_TO_BORDER_EXT = 0x8912;
    }
}
#endif