#if (GL_INTEL_performance_query && (GL_API || GLCORE_API || GLES2_API))
public partial class intel { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PERFQUERY_SINGLE_CONTEXT_INTEL = 0x00000000;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PERFQUERY_GLOBAL_CONTEXT_INTEL = 0x00000001;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PERFQUERY_DONOT_FLUSH_INTEL = 0x83F9;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PERFQUERY_FLUSH_INTEL = 0x83FA;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PERFQUERY_WAIT_INTEL = 0x83FB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PERFQUERY_COUNTER_EVENT_INTEL = 0x94F0;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PERFQUERY_COUNTER_DURATION_NORM_INTEL = 0x94F1;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PERFQUERY_COUNTER_DURATION_RAW_INTEL = 0x94F2;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PERFQUERY_COUNTER_THROUGHPUT_INTEL = 0x94F3;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PERFQUERY_COUNTER_RAW_INTEL = 0x94F4;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PERFQUERY_COUNTER_TIMESTAMP_INTEL = 0x94F5;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PERFQUERY_COUNTER_DATA_UINT32_INTEL = 0x94F8;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PERFQUERY_COUNTER_DATA_UINT64_INTEL = 0x94F9;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PERFQUERY_COUNTER_DATA_FLOAT_INTEL = 0x94FA;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PERFQUERY_COUNTER_DATA_DOUBLE_INTEL = 0x94FB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PERFQUERY_COUNTER_DATA_BOOL32_INTEL = 0x94FC;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PERFQUERY_QUERY_NAME_LENGTH_MAX_INTEL = 0x94FD;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PERFQUERY_COUNTER_NAME_LENGTH_MAX_INTEL = 0x94FE;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PERFQUERY_COUNTER_DESC_LENGTH_MAX_INTEL = 0x94FF;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PERFQUERY_GPA_EXTENDED_COUNTERS_INTEL = 0x9500;
#endif
    }
}
#endif