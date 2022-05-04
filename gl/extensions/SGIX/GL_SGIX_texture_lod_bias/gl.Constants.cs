#if (GL_SGIX_texture_lod_bias && GL_API)
public partial class sgix { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_LOD_BIAS_S_SGIX = 0x818E;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_LOD_BIAS_T_SGIX = 0x818F;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_LOD_BIAS_R_SGIX = 0x8190;
#endif
    }
}
#endif