#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0 || GL_NV_COVERAGE_SAMPLE)
[Flags]
public enum ClearBufferMask : GLbitfield { 
    None = 0,
#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    DepthBuffer = gl.Constants.GL_DEPTH_BUFFER_BIT, 
#endif

#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    StencilBuffer = gl.Constants.GL_STENCIL_BUFFER_BIT, 
#endif

#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    ColorBuffer = gl.Constants.GL_COLOR_BUFFER_BIT, 
#endif

#if GL_VERSION_1_0
    AccumBuffer = gl.Constants.GL_ACCUM_BUFFER_BIT, 
#endif

#if GL_NV_COVERAGE_SAMPLE
    CoverageBitNv = gl.Constants.GL_COVERAGE_BUFFER_BIT_NV, 
#endif

}

#endif
