#if (GL_SGIX_texture_coordinate_clamp && GL_API)
public partial class sgix { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_MAX_CLAMP_S_SGIX = 0x8369;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_MAX_CLAMP_T_SGIX = 0x836A;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_MAX_CLAMP_R_SGIX = 0x836B;
#endif
    }
}
#endif