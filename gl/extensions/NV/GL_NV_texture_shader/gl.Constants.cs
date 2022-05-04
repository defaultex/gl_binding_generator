#if (GL_NV_texture_shader && GL_API)
public partial class nv { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_OFFSET_TEXTURE_RECTANGLE_NV = 0x864C;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_OFFSET_TEXTURE_RECTANGLE_SCALE_NV = 0x864D;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_DOT_PRODUCT_TEXTURE_RECTANGLE_NV = 0x864E;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_RGBA_UNSIGNED_DOT_PRODUCT_MAPPING_NV = 0x86D9;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_UNSIGNED_INT_S8_S8_8_8_NV = 0x86DA;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_UNSIGNED_INT_8_8_S8_S8_REV_NV = 0x86DB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_DSDT_MAG_INTENSITY_NV = 0x86DC;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SHADER_CONSISTENT_NV = 0x86DD;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_SHADER_NV = 0x86DE;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SHADER_OPERATION_NV = 0x86DF;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_CULL_MODES_NV = 0x86E0;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_OFFSET_TEXTURE_2D_MATRIX_NV = 0x86E1;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_OFFSET_TEXTURE_MATRIX_NV = 0x86E1;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_OFFSET_TEXTURE_2D_SCALE_NV = 0x86E2;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_OFFSET_TEXTURE_SCALE_NV = 0x86E2;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_OFFSET_TEXTURE_2D_BIAS_NV = 0x86E3;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_OFFSET_TEXTURE_BIAS_NV = 0x86E3;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PREVIOUS_TEXTURE_INPUT_NV = 0x86E4;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_CONST_EYE_NV = 0x86E5;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PASS_THROUGH_NV = 0x86E6;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_CULL_FRAGMENT_NV = 0x86E7;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_OFFSET_TEXTURE_2D_NV = 0x86E8;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_DEPENDENT_AR_TEXTURE_2D_NV = 0x86E9;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_DEPENDENT_GB_TEXTURE_2D_NV = 0x86EA;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_DOT_PRODUCT_NV = 0x86EC;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_DOT_PRODUCT_DEPTH_REPLACE_NV = 0x86ED;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_DOT_PRODUCT_TEXTURE_2D_NV = 0x86EE;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_DOT_PRODUCT_TEXTURE_CUBE_MAP_NV = 0x86F0;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_DOT_PRODUCT_DIFFUSE_CUBE_MAP_NV = 0x86F1;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_DOT_PRODUCT_REFLECT_CUBE_MAP_NV = 0x86F2;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_DOT_PRODUCT_CONST_EYE_REFLECT_CUBE_MAP_NV = 0x86F3;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_HILO_NV = 0x86F4;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_DSDT_NV = 0x86F5;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_DSDT_MAG_NV = 0x86F6;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_DSDT_MAG_VIB_NV = 0x86F7;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_HILO16_NV = 0x86F8;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SIGNED_HILO_NV = 0x86F9;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SIGNED_HILO16_NV = 0x86FA;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SIGNED_RGBA_NV = 0x86FB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SIGNED_RGBA8_NV = 0x86FC;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SIGNED_RGB_NV = 0x86FE;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SIGNED_RGB8_NV = 0x86FF;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SIGNED_LUMINANCE_NV = 0x8701;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SIGNED_LUMINANCE8_NV = 0x8702;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SIGNED_LUMINANCE_ALPHA_NV = 0x8703;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SIGNED_LUMINANCE8_ALPHA8_NV = 0x8704;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SIGNED_ALPHA_NV = 0x8705;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SIGNED_ALPHA8_NV = 0x8706;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SIGNED_INTENSITY_NV = 0x8707;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SIGNED_INTENSITY8_NV = 0x8708;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_DSDT8_NV = 0x8709;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_DSDT8_MAG8_NV = 0x870A;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_DSDT8_MAG8_INTENSITY8_NV = 0x870B;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SIGNED_RGB_UNSIGNED_ALPHA_NV = 0x870C;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SIGNED_RGB8_UNSIGNED_ALPHA8_NV = 0x870D;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_HI_SCALE_NV = 0x870E;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_LO_SCALE_NV = 0x870F;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_DS_SCALE_NV = 0x8710;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_DT_SCALE_NV = 0x8711;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAGNITUDE_SCALE_NV = 0x8712;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_VIBRANCE_SCALE_NV = 0x8713;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_HI_BIAS_NV = 0x8714;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_LO_BIAS_NV = 0x8715;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_DS_BIAS_NV = 0x8716;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_DT_BIAS_NV = 0x8717;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAGNITUDE_BIAS_NV = 0x8718;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_VIBRANCE_BIAS_NV = 0x8719;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_BORDER_VALUES_NV = 0x871A;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_HI_SIZE_NV = 0x871B;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_LO_SIZE_NV = 0x871C;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_DS_SIZE_NV = 0x871D;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_DT_SIZE_NV = 0x871E;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_MAG_SIZE_NV = 0x871F;
#endif
    }
}
#endif