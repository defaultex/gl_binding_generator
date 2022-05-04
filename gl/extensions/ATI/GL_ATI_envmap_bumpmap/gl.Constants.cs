#if (GL_ATI_envmap_bumpmap && GL_API)
public partial class ati { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_BUMP_ROT_MATRIX_ATI = 0x8775;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_BUMP_ROT_MATRIX_SIZE_ATI = 0x8776;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_BUMP_NUM_TEX_UNITS_ATI = 0x8777;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_BUMP_TEX_UNITS_ATI = 0x8778;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_DUDV_ATI = 0x8779;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_DU8DV8_ATI = 0x877A;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_BUMP_ENVMAP_ATI = 0x877B;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_BUMP_TARGET_ATI = 0x877C;
#endif
    }
}
#endif