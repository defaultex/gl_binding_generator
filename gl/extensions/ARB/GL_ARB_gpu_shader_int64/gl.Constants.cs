#if (GL_ARB_gpu_shader_int64 && (GL_API || GLCORE_API))
public partial class arb { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_INT64_ARB = 0x140E;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_UNSIGNED_INT64_ARB = 0x140F;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_INT64_VEC2_ARB = 0x8FE9;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_INT64_VEC3_ARB = 0x8FEA;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_INT64_VEC4_ARB = 0x8FEB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_UNSIGNED_INT64_VEC2_ARB = 0x8FF5;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_UNSIGNED_INT64_VEC3_ARB = 0x8FF6;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_UNSIGNED_INT64_VEC4_ARB = 0x8FF7;
#endif
    }
}
#endif