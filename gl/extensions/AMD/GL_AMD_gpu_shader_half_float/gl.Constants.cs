#if (GL_AMD_gpu_shader_half_float && GL_API)
public partial class amd { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_FLOAT16_NV = 0x8FF8;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_FLOAT16_VEC2_NV = 0x8FF9;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_FLOAT16_VEC3_NV = 0x8FFA;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_FLOAT16_VEC4_NV = 0x8FFB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_FLOAT16_MAT2_AMD = 0x91C5;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_FLOAT16_MAT3_AMD = 0x91C6;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_FLOAT16_MAT4_AMD = 0x91C7;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_FLOAT16_MAT2x3_AMD = 0x91C8;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_FLOAT16_MAT2x4_AMD = 0x91C9;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_FLOAT16_MAT3x2_AMD = 0x91CA;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_FLOAT16_MAT3x4_AMD = 0x91CB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_FLOAT16_MAT4x2_AMD = 0x91CC;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_FLOAT16_MAT4x3_AMD = 0x91CD;
#endif
    }
}
#endif