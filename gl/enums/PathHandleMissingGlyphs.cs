#if GL_NV_PATH_RENDERING

public enum PathHandleMissingGlyphs : GLenum { 
#if GL_NV_PATH_RENDERING
    SkipMissingGlyphNv = gl.Constants.GL_SKIP_MISSING_GLYPH_NV, 
#endif

#if GL_NV_PATH_RENDERING
    UseMissingGlyphNv = gl.Constants.GL_USE_MISSING_GLYPH_NV, 
#endif

}

#endif
