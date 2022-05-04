#if (GL_EXT_texture3D && GL_API)
public partial class ext { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PACK_SKIP_IMAGES_EXT = 0x806B;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PACK_IMAGE_HEIGHT_EXT = 0x806C;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_UNPACK_SKIP_IMAGES_EXT = 0x806D;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_UNPACK_IMAGE_HEIGHT_EXT = 0x806E;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_3D_EXT = 0x806F;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PROXY_TEXTURE_3D_EXT = 0x8070;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_DEPTH_EXT = 0x8071;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_WRAP_R_EXT = 0x8072;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_3D_TEXTURE_SIZE_EXT = 0x8073;
#endif
    }
}
#endif