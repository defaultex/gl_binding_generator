#if (GL_ANGLE_texture_compression_dxt3 && GLES2_API)
public partial class angle { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_COMPRESSED_RGBA_S3TC_DXT3_ANGLE = 0x83F2;
#endif
    }
}
#endif