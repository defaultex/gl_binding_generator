#if (GL_NV_texture_shader3 && GL_API)
public partial class nv { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_OFFSET_PROJECTIVE_TEXTURE_2D_NV = 0x8850;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_OFFSET_PROJECTIVE_TEXTURE_2D_SCALE_NV = 0x8851;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_OFFSET_PROJECTIVE_TEXTURE_RECTANGLE_NV = 0x8852;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_OFFSET_PROJECTIVE_TEXTURE_RECTANGLE_SCALE_NV = 0x8853;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_OFFSET_HILO_TEXTURE_2D_NV = 0x8854;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_OFFSET_HILO_TEXTURE_RECTANGLE_NV = 0x8855;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_OFFSET_HILO_PROJECTIVE_TEXTURE_2D_NV = 0x8856;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_OFFSET_HILO_PROJECTIVE_TEXTURE_RECTANGLE_NV = 0x8857;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_DEPENDENT_HILO_TEXTURE_2D_NV = 0x8858;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_DEPENDENT_RGB_TEXTURE_3D_NV = 0x8859;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_DEPENDENT_RGB_TEXTURE_CUBE_MAP_NV = 0x885A;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_DOT_PRODUCT_PASS_THROUGH_NV = 0x885B;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_DOT_PRODUCT_TEXTURE_1D_NV = 0x885C;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_DOT_PRODUCT_AFFINE_DEPTH_REPLACE_NV = 0x885D;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_HILO8_NV = 0x885E;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SIGNED_HILO8_NV = 0x885F;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_FORCE_BLUE_TO_ONE_NV = 0x8860;
#endif
    }
}
#endif