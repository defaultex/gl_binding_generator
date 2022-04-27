#if GL_AMD_OCCLUSION_QUERY_EVENT

public enum OcclusionQueryEventMaskAMD : GLenum { 
#if GL_AMD_OCCLUSION_QUERY_EVENT
    QueryDepthPassEventBitAmd = gl.Constants.GL_QUERY_DEPTH_PASS_EVENT_BIT_AMD, 
#endif

#if GL_AMD_OCCLUSION_QUERY_EVENT
    QueryDepthFailEventBitAmd = gl.Constants.GL_QUERY_DEPTH_FAIL_EVENT_BIT_AMD, 
#endif

#if GL_AMD_OCCLUSION_QUERY_EVENT
    QueryStencilFailEventBitAmd = gl.Constants.GL_QUERY_STENCIL_FAIL_EVENT_BIT_AMD, 
#endif

#if GL_AMD_OCCLUSION_QUERY_EVENT
    QueryDepthBoundsFailEventBitAmd = gl.Constants.GL_QUERY_DEPTH_BOUNDS_FAIL_EVENT_BIT_AMD, 
#endif

#if GL_AMD_OCCLUSION_QUERY_EVENT
    QueryAllBitsAmd = gl.Constants.GL_QUERY_ALL_EVENT_BITS_AMD, 
#endif

}

#endif
