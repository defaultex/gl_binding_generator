#if GL_INTEL_performance_query

public enum PerformanceQueryCapsMaskINTEL : GLenum {
#if GL_INTEL_performance_query
    PerfquerySingleContextIntel = gl.Constants.GL_PERFQUERY_SINGLE_CONTEXT_INTEL,
#endif

#if GL_INTEL_performance_query
    PerfqueryGlobalContextIntel = gl.Constants.GL_PERFQUERY_GLOBAL_CONTEXT_INTEL,
#endif
}

#endif