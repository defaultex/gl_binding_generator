#if (GL_3DFX_texture_compression_FXT1 && GL_API)
public partial class 3dfx { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_COMPRESSED_RGB_FXT1_3DFX = 0x86B0;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_COMPRESSED_RGBA_FXT1_3DFX = 0x86B1;
#endif
    }
}
#endif