#if (GL_KHR_blend_equation_advanced && (GL_API || GLCORE_API || GLES2_API))
public partial class khr { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MULTIPLY_KHR = 0x9294;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SCREEN_KHR = 0x9295;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_OVERLAY_KHR = 0x9296;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_DARKEN_KHR = 0x9297;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_LIGHTEN_KHR = 0x9298;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_COLORDODGE_KHR = 0x9299;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_COLORBURN_KHR = 0x929A;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_HARDLIGHT_KHR = 0x929B;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SOFTLIGHT_KHR = 0x929C;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_DIFFERENCE_KHR = 0x929E;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_EXCLUSION_KHR = 0x92A0;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_HSL_HUE_KHR = 0x92AD;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_HSL_SATURATION_KHR = 0x92AE;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_HSL_COLOR_KHR = 0x92AF;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_HSL_LUMINOSITY_KHR = 0x92B0;
#endif
    }
}
#endif