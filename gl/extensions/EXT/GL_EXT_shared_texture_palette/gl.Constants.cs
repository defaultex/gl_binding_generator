#if (GL_EXT_shared_texture_palette && GL_API)
public partial class ext { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SHARED_TEXTURE_PALETTE_EXT = 0x81FB;
#endif
    }
}
#endif