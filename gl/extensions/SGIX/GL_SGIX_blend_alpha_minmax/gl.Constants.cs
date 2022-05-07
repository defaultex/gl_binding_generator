#if (GL_SGIX_blend_alpha_minmax && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_ALPHA_MIN_SGIX = 0x8320;
        public const GLenum GL_ALPHA_MAX_SGIX = 0x8321;
    }
}
#endif