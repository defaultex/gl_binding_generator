#if (GL_SGIX_shadow && GL_API)
public partial class sgix { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_COMPARE_SGIX = 0x819A;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_COMPARE_OPERATOR_SGIX = 0x819B;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_LEQUAL_R_SGIX = 0x819C;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_GEQUAL_R_SGIX = 0x819D;
#endif
    }
}
#endif