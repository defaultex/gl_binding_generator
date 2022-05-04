#if (GL_EXT_texture_compression_astc_decode_mode && GLES2_API)
public partial class ext { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_ASTC_DECODE_PRECISION_EXT = 0x8F69;
#endif
    }
}
#endif