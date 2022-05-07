#if (GL_AMD_performance_monitor && (!gl || !glcore || !gles2))
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_COUNTER_TYPE_AMD = 0x8BC0;
        public const GLenum GL_COUNTER_RANGE_AMD = 0x8BC1;
        public const GLenum GL_UNSIGNED_INT64_AMD = 0x8BC2;
        public const GLenum GL_PERCENTAGE_AMD = 0x8BC3;
        public const GLenum GL_PERFMON_RESULT_AVAILABLE_AMD = 0x8BC4;
        public const GLenum GL_PERFMON_RESULT_SIZE_AMD = 0x8BC5;
        public const GLenum GL_PERFMON_RESULT_AMD = 0x8BC6;
    }
}
#endif