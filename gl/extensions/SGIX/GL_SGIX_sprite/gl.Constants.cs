#if (GL_SGIX_sprite && GL_API)
public partial class sgix { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SPRITE_SGIX = 0x8148;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SPRITE_MODE_SGIX = 0x8149;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SPRITE_AXIS_SGIX = 0x814A;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SPRITE_TRANSLATION_SGIX = 0x814B;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SPRITE_AXIAL_SGIX = 0x814C;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SPRITE_OBJECT_ALIGNED_SGIX = 0x814D;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SPRITE_EYE_ALIGNED_SGIX = 0x814E;
#endif
    }
}
#endif