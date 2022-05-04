#if (GL_EXT_texture_norm16 && GLES2_API)
public partial class ext { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_RGB16_EXT = 0x8054;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_RGBA16_EXT = 0x805B;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_R16_EXT = 0x822A;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_RG16_EXT = 0x822C;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_R16_SNORM_EXT = 0x8F98;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_RG16_SNORM_EXT = 0x8F99;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_RGB16_SNORM_EXT = 0x8F9A;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_RGBA16_SNORM_EXT = 0x8F9B;
#endif
    }
}
#endif