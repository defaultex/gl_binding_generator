#if (GL_EXT_shared_texture_palette && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_SHARED_TEXTURE_PALETTE_EXT = 0x81FB;
    }
}
#endif