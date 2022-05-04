#if (GL_EXT_texture_snorm && GL_API)
public partial class ext { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_RED_SNORM = 0x8F90;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_RG_SNORM = 0x8F91;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_RGB_SNORM = 0x8F92;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_RGBA_SNORM = 0x8F93;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_R8_SNORM = 0x8F94;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_RG8_SNORM = 0x8F95;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_RGB8_SNORM = 0x8F96;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_RGBA8_SNORM = 0x8F97;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_R16_SNORM = 0x8F98;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_RG16_SNORM = 0x8F99;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_RGB16_SNORM = 0x8F9A;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_RGBA16_SNORM = 0x8F9B;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_SIGNED_NORMALIZED = 0x8F9C;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_ALPHA_SNORM = 0x9010;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_LUMINANCE_SNORM = 0x9011;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_LUMINANCE_ALPHA_SNORM = 0x9012;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_INTENSITY_SNORM = 0x9013;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_ALPHA8_SNORM = 0x9014;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_LUMINANCE8_SNORM = 0x9015;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_LUMINANCE8_ALPHA8_SNORM = 0x9016;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_INTENSITY8_SNORM = 0x9017;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_ALPHA16_SNORM = 0x9018;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_LUMINANCE16_SNORM = 0x9019;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_LUMINANCE16_ALPHA16_SNORM = 0x901A;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_INTENSITY16_SNORM = 0x901B;
#endif
    }
}
#endif