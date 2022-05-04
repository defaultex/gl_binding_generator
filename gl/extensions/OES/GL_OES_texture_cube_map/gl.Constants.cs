#if (GL_OES_texture_cube_map && GLES1_API)
public partial class oes { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_GEN_MODE_OES = 0x2500;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_NORMAL_MAP_OES = 0x8511;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_REFLECTION_MAP_OES = 0x8512;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_CUBE_MAP_OES = 0x8513;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_BINDING_CUBE_MAP_OES = 0x8514;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_CUBE_MAP_POSITIVE_X_OES = 0x8515;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_CUBE_MAP_NEGATIVE_X_OES = 0x8516;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_CUBE_MAP_POSITIVE_Y_OES = 0x8517;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_CUBE_MAP_NEGATIVE_Y_OES = 0x8518;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_CUBE_MAP_POSITIVE_Z_OES = 0x8519;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_CUBE_MAP_NEGATIVE_Z_OES = 0x851A;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_CUBE_MAP_TEXTURE_SIZE_OES = 0x851C;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_GEN_STR_OES = 0x8D60;
#endif
    }
}
#endif