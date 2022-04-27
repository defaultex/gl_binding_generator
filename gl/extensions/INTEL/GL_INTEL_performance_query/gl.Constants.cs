#if (GL_INTEL_performance_query && (GL_API || GLCORE_API || GLES2_API))
public partial class glext_intel { 
    public partial class Constants { 
        public const GLenum GL_PERFQUERY_SINGLE_CONTEXT_INTEL = 0x00000000;
        public const GLenum GL_PERFQUERY_GLOBAL_CONTEXT_INTEL = 0x00000001;
        public const GLenum GL_PERFQUERY_DONOT_FLUSH_INTEL = 0x83F9;
        public const GLenum GL_PERFQUERY_FLUSH_INTEL = 0x83FA;
        public const GLenum GL_PERFQUERY_WAIT_INTEL = 0x83FB;
        public const GLenum GL_PERFQUERY_COUNTER_EVENT_INTEL = 0x94F0;
        public const GLenum GL_PERFQUERY_COUNTER_DURATION_NORM_INTEL = 0x94F1;
        public const GLenum GL_PERFQUERY_COUNTER_DURATION_RAW_INTEL = 0x94F2;
        public const GLenum GL_PERFQUERY_COUNTER_THROUGHPUT_INTEL = 0x94F3;
        public const GLenum GL_PERFQUERY_COUNTER_RAW_INTEL = 0x94F4;
        public const GLenum GL_PERFQUERY_COUNTER_TIMESTAMP_INTEL = 0x94F5;
        public const GLenum GL_PERFQUERY_COUNTER_DATA_UINT32_INTEL = 0x94F8;
        public const GLenum GL_PERFQUERY_COUNTER_DATA_UINT64_INTEL = 0x94F9;
        public const GLenum GL_PERFQUERY_COUNTER_DATA_FLOAT_INTEL = 0x94FA;
        public const GLenum GL_PERFQUERY_COUNTER_DATA_DOUBLE_INTEL = 0x94FB;
        public const GLenum GL_PERFQUERY_COUNTER_DATA_BOOL32_INTEL = 0x94FC;
        public const GLenum GL_PERFQUERY_QUERY_NAME_LENGTH_MAX_INTEL = 0x94FD;
        public const GLenum GL_PERFQUERY_COUNTER_NAME_LENGTH_MAX_INTEL = 0x94FE;
        public const GLenum GL_PERFQUERY_COUNTER_DESC_LENGTH_MAX_INTEL = 0x94FF;
        public const GLenum GL_PERFQUERY_GPA_EXTENDED_COUNTERS_INTEL = 0x9500;
    }
}
#endif