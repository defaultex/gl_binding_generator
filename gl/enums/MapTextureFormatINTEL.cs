#if GL_INTEL_MAP_TEXTURE

public enum MapTextureFormatINTEL : GLenum { 
#if GL_INTEL_MAP_TEXTURE
    LayoutDefaultIntel = gl.Constants.GL_LAYOUT_DEFAULT_INTEL, 
#endif

#if GL_INTEL_MAP_TEXTURE
    LayoutLinearIntel = gl.Constants.GL_LAYOUT_LINEAR_INTEL, 
#endif

#if GL_INTEL_MAP_TEXTURE
    LayoutLinearCpuCachedIntel = gl.Constants.GL_LAYOUT_LINEAR_CPU_CACHED_INTEL, 
#endif

}

#endif
