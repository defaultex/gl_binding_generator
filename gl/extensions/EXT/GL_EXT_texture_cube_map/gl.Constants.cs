#if (GL_EXT_texture_cube_map && GL_API)
public partial class ext { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_NORMAL_MAP_EXT = 0x8511;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_REFLECTION_MAP_EXT = 0x8512;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_CUBE_MAP_EXT = 0x8513;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_BINDING_CUBE_MAP_EXT = 0x8514;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_CUBE_MAP_POSITIVE_X_EXT = 0x8515;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_CUBE_MAP_NEGATIVE_X_EXT = 0x8516;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_CUBE_MAP_POSITIVE_Y_EXT = 0x8517;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_CUBE_MAP_NEGATIVE_Y_EXT = 0x8518;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_CUBE_MAP_POSITIVE_Z_EXT = 0x8519;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_CUBE_MAP_NEGATIVE_Z_EXT = 0x851A;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PROXY_TEXTURE_CUBE_MAP_EXT = 0x851B;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_CUBE_MAP_TEXTURE_SIZE_EXT = 0x851C;
#endif
    }
}
#endif