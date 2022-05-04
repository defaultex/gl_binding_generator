#if (GL_ATI_texture_float && GL_API)
public partial class ati { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_RGBA_FLOAT32_ATI = 0x8814;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_RGB_FLOAT32_ATI = 0x8815;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_ALPHA_FLOAT32_ATI = 0x8816;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_INTENSITY_FLOAT32_ATI = 0x8817;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_LUMINANCE_FLOAT32_ATI = 0x8818;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_LUMINANCE_ALPHA_FLOAT32_ATI = 0x8819;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_RGBA_FLOAT16_ATI = 0x881A;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_RGB_FLOAT16_ATI = 0x881B;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_ALPHA_FLOAT16_ATI = 0x881C;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_INTENSITY_FLOAT16_ATI = 0x881D;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_LUMINANCE_FLOAT16_ATI = 0x881E;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_LUMINANCE_ALPHA_FLOAT16_ATI = 0x881F;
#endif
    }
}
#endif