#if GL_INTEL_PERFORMANCE_QUERY

public enum PerformanceQueryCapsMaskINTEL : GLenum { 
#if GL_INTEL_PERFORMANCE_QUERY
    PerfquerySingleContextIntel = gl.Constants.GL_PERFQUERY_SINGLE_CONTEXT_INTEL, 
#endif

#if GL_INTEL_PERFORMANCE_QUERY
    PerfqueryGlobalContextIntel = gl.Constants.GL_PERFQUERY_GLOBAL_CONTEXT_INTEL, 
#endif

}

#endif
