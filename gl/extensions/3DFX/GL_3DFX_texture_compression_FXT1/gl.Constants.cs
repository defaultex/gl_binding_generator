#if (GL_3DFX_texture_compression_FXT1 && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_COMPRESSED_RGB_FXT1_3DFX = 0x86B0;
        public const GLenum GL_COMPRESSED_RGBA_FXT1_3DFX = 0x86B1;
    }
}
#endif