#if (GL_SGIX_pixel_texture && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_PIXEL_TEX_GEN_SGIX = 0x8139;
        public const GLenum GL_PIXEL_TEX_GEN_MODE_SGIX = 0x832B;
    }
}
#endif