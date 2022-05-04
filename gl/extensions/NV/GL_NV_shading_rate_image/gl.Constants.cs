#if (GL_NV_shading_rate_image && (GL_API || GLCORE_API || GLES2_API))
public partial class nv { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SHADING_RATE_IMAGE_BINDING_NV = 0x955B;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SHADING_RATE_IMAGE_TEXEL_WIDTH_NV = 0x955C;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SHADING_RATE_IMAGE_TEXEL_HEIGHT_NV = 0x955D;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SHADING_RATE_IMAGE_PALETTE_SIZE_NV = 0x955E;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_COARSE_FRAGMENT_SAMPLES_NV = 0x955F;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SHADING_RATE_IMAGE_NV = 0x9563;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SHADING_RATE_NO_INVOCATIONS_NV = 0x9564;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SHADING_RATE_1_INVOCATION_PER_PIXEL_NV = 0x9565;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SHADING_RATE_1_INVOCATION_PER_1X2_PIXELS_NV = 0x9566;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SHADING_RATE_1_INVOCATION_PER_2X1_PIXELS_NV = 0x9567;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SHADING_RATE_1_INVOCATION_PER_2X2_PIXELS_NV = 0x9568;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SHADING_RATE_1_INVOCATION_PER_2X4_PIXELS_NV = 0x9569;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SHADING_RATE_1_INVOCATION_PER_4X2_PIXELS_NV = 0x956A;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SHADING_RATE_1_INVOCATION_PER_4X4_PIXELS_NV = 0x956B;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SHADING_RATE_2_INVOCATIONS_PER_PIXEL_NV = 0x956C;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SHADING_RATE_4_INVOCATIONS_PER_PIXEL_NV = 0x956D;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SHADING_RATE_8_INVOCATIONS_PER_PIXEL_NV = 0x956E;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SHADING_RATE_16_INVOCATIONS_PER_PIXEL_NV = 0x956F;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SHADING_RATE_SAMPLE_ORDER_DEFAULT_NV = 0x95AE;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SHADING_RATE_SAMPLE_ORDER_PIXEL_MAJOR_NV = 0x95AF;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SHADING_RATE_SAMPLE_ORDER_SAMPLE_MAJOR_NV = 0x95B0;
#endif
    }
}
#endif