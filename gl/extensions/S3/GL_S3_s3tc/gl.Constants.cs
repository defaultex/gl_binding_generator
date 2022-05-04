#if (GL_S3_s3tc && GL_API)
public partial class s3 { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_RGB_S3TC = 0x83A0;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_RGB4_S3TC = 0x83A1;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_RGBA_S3TC = 0x83A2;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_RGBA4_S3TC = 0x83A3;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_RGBA_DXT5_S3TC = 0x83A4;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_RGBA4_DXT5_S3TC = 0x83A5;
#endif
    }
}
#endif