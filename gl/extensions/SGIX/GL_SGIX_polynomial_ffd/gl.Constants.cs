#if (GL_SGIX_polynomial_ffd && GL_API)
public partial class sgix { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_DEFORMATION_BIT_SGIX = 0x00000001;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_GEOMETRY_DEFORMATION_BIT_SGIX = 0x00000002;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_GEOMETRY_DEFORMATION_SGIX = 0x8194;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_DEFORMATION_SGIX = 0x8195;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_DEFORMATIONS_MASK_SGIX = 0x8196;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_DEFORMATION_ORDER_SGIX = 0x8197;
#endif
    }
}
#endif