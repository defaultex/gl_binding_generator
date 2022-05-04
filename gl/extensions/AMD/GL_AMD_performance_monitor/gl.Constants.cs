#if (GL_AMD_performance_monitor && (GL_API || GLCORE_API || GLES2_API))
public partial class amd { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_COUNTER_TYPE_AMD = 0x8BC0;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_COUNTER_RANGE_AMD = 0x8BC1;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_UNSIGNED_INT64_AMD = 0x8BC2;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PERCENTAGE_AMD = 0x8BC3;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PERFMON_RESULT_AVAILABLE_AMD = 0x8BC4;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PERFMON_RESULT_SIZE_AMD = 0x8BC5;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PERFMON_RESULT_AMD = 0x8BC6;
#endif
    }
}
#endif