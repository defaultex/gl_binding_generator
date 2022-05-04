#if (GL_SGIS_texture_lod && GL_API)
public partial class sgis { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_MIN_LOD_SGIS = 0x813A;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_MAX_LOD_SGIS = 0x813B;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_BASE_LEVEL_SGIS = 0x813C;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_MAX_LEVEL_SGIS = 0x813D;
#endif
    }
}
#endif