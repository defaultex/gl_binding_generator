#if (GL_NV_blend_equation_advanced && (GL_API || GLCORE_API || GLES2_API))
public partial class nv { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_ZERO = 0;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_XOR_NV = 0x1506;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_INVERT = 0x150A;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_RED_NV = 0x1903;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_GREEN_NV = 0x1904;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_BLUE_NV = 0x1905;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_BLEND_PREMULTIPLIED_SRC_NV = 0x9280;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_BLEND_OVERLAP_NV = 0x9281;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_UNCORRELATED_NV = 0x9282;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_DISJOINT_NV = 0x9283;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_CONJOINT_NV = 0x9284;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SRC_NV = 0x9286;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_DST_NV = 0x9287;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SRC_OVER_NV = 0x9288;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_DST_OVER_NV = 0x9289;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SRC_IN_NV = 0x928A;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_DST_IN_NV = 0x928B;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SRC_OUT_NV = 0x928C;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_DST_OUT_NV = 0x928D;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SRC_ATOP_NV = 0x928E;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_DST_ATOP_NV = 0x928F;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PLUS_NV = 0x9291;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PLUS_DARKER_NV = 0x9292;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MULTIPLY_NV = 0x9294;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SCREEN_NV = 0x9295;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_OVERLAY_NV = 0x9296;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_DARKEN_NV = 0x9297;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_LIGHTEN_NV = 0x9298;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_COLORDODGE_NV = 0x9299;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_COLORBURN_NV = 0x929A;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_HARDLIGHT_NV = 0x929B;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SOFTLIGHT_NV = 0x929C;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_DIFFERENCE_NV = 0x929E;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MINUS_NV = 0x929F;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_EXCLUSION_NV = 0x92A0;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_CONTRAST_NV = 0x92A1;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_INVERT_RGB_NV = 0x92A3;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_LINEARDODGE_NV = 0x92A4;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_LINEARBURN_NV = 0x92A5;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_VIVIDLIGHT_NV = 0x92A6;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_LINEARLIGHT_NV = 0x92A7;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PINLIGHT_NV = 0x92A8;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_HARDMIX_NV = 0x92A9;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_HSL_HUE_NV = 0x92AD;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_HSL_SATURATION_NV = 0x92AE;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_HSL_COLOR_NV = 0x92AF;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_HSL_LUMINOSITY_NV = 0x92B0;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PLUS_CLAMPED_NV = 0x92B1;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PLUS_CLAMPED_ALPHA_NV = 0x92B2;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MINUS_CLAMPED_NV = 0x92B3;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_INVERT_OVG_NV = 0x92B4;
#endif
    }
}
#endif