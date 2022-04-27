#if (GL_KHR_blend_equation_advanced && (GL_API || GLCORE_API || GLES2_API))
public partial class glext_khr { 
    public partial class Constants { 
        public const GLenum GL_MULTIPLY_KHR = 0x9294;
        public const GLenum GL_SCREEN_KHR = 0x9295;
        public const GLenum GL_OVERLAY_KHR = 0x9296;
        public const GLenum GL_DARKEN_KHR = 0x9297;
        public const GLenum GL_LIGHTEN_KHR = 0x9298;
        public const GLenum GL_COLORDODGE_KHR = 0x9299;
        public const GLenum GL_COLORBURN_KHR = 0x929A;
        public const GLenum GL_HARDLIGHT_KHR = 0x929B;
        public const GLenum GL_SOFTLIGHT_KHR = 0x929C;
        public const GLenum GL_DIFFERENCE_KHR = 0x929E;
        public const GLenum GL_EXCLUSION_KHR = 0x92A0;
        public const GLenum GL_HSL_HUE_KHR = 0x92AD;
        public const GLenum GL_HSL_SATURATION_KHR = 0x92AE;
        public const GLenum GL_HSL_COLOR_KHR = 0x92AF;
        public const GLenum GL_HSL_LUMINOSITY_KHR = 0x92B0;
    }
}
#endif