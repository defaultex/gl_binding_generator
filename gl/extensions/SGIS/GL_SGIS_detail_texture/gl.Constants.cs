#if (GL_SGIS_detail_texture && GL_API)
public partial class sgis { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_DETAIL_TEXTURE_2D_SGIS = 0x8095;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_DETAIL_TEXTURE_2D_BINDING_SGIS = 0x8096;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_LINEAR_DETAIL_SGIS = 0x8097;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_LINEAR_DETAIL_ALPHA_SGIS = 0x8098;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_LINEAR_DETAIL_COLOR_SGIS = 0x8099;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_DETAIL_TEXTURE_LEVEL_SGIS = 0x809A;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_DETAIL_TEXTURE_MODE_SGIS = 0x809B;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_DETAIL_TEXTURE_FUNC_POINTS_SGIS = 0x809C;
#endif
    }
}
#endif