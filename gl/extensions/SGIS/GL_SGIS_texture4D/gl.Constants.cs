#if (GL_SGIS_texture4D && GL_API)
public partial class sgis { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PACK_SKIP_VOLUMES_SGIS = 0x8130;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PACK_IMAGE_DEPTH_SGIS = 0x8131;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_UNPACK_SKIP_VOLUMES_SGIS = 0x8132;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_UNPACK_IMAGE_DEPTH_SGIS = 0x8133;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_4D_SGIS = 0x8134;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PROXY_TEXTURE_4D_SGIS = 0x8135;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_4DSIZE_SGIS = 0x8136;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_WRAP_Q_SGIS = 0x8137;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_4D_TEXTURE_SIZE_SGIS = 0x8138;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_4D_BINDING_SGIS = 0x814F;
#endif
    }
}
#endif