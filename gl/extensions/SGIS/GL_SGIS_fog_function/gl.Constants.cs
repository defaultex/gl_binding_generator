#if (GL_SGIS_fog_function && GL_API)
public partial class sgis { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_FOG_FUNC_SGIS = 0x812A;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_FOG_FUNC_POINTS_SGIS = 0x812B;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_FOG_FUNC_POINTS_SGIS = 0x812C;
#endif
    }
}
#endif