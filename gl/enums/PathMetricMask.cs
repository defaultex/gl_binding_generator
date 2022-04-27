#if GL_NV_PATH_RENDERING
[Flags]
public enum PathMetricMask : GLbitfield { 
    None = 0,
#if GL_NV_PATH_RENDERING
    GlyphWidthBitNv = gl.Constants.GL_GLYPH_WIDTH_BIT_NV, 
#endif

#if GL_NV_PATH_RENDERING
    GlyphHeightBitNv = gl.Constants.GL_GLYPH_HEIGHT_BIT_NV, 
#endif

#if GL_NV_PATH_RENDERING
    GlyphHorizontalBearingXBitNv = gl.Constants.GL_GLYPH_HORIZONTAL_BEARING_X_BIT_NV, 
#endif

#if GL_NV_PATH_RENDERING
    GlyphHorizontalBearingYBitNv = gl.Constants.GL_GLYPH_HORIZONTAL_BEARING_Y_BIT_NV, 
#endif

#if GL_NV_PATH_RENDERING
    GlyphHorizontalBearingAdvanceBitNv = gl.Constants.GL_GLYPH_HORIZONTAL_BEARING_ADVANCE_BIT_NV, 
#endif

#if GL_NV_PATH_RENDERING
    GlyphVerticalBearingXBitNv = gl.Constants.GL_GLYPH_VERTICAL_BEARING_X_BIT_NV, 
#endif

#if GL_NV_PATH_RENDERING
    GlyphVerticalBearingYBitNv = gl.Constants.GL_GLYPH_VERTICAL_BEARING_Y_BIT_NV, 
#endif

#if GL_NV_PATH_RENDERING
    GlyphVerticalBearingAdvanceBitNv = gl.Constants.GL_GLYPH_VERTICAL_BEARING_ADVANCE_BIT_NV, 
#endif

#if GL_NV_PATH_RENDERING
    GlyphHasKerningBitNv = gl.Constants.GL_GLYPH_HAS_KERNING_BIT_NV, 
#endif

#if GL_NV_PATH_RENDERING
    FontXMinBoundsBitNv = gl.Constants.GL_FONT_X_MIN_BOUNDS_BIT_NV, 
#endif

#if GL_NV_PATH_RENDERING
    FontYMinBoundsBitNv = gl.Constants.GL_FONT_Y_MIN_BOUNDS_BIT_NV, 
#endif

#if GL_NV_PATH_RENDERING
    FontXMaxBoundsBitNv = gl.Constants.GL_FONT_X_MAX_BOUNDS_BIT_NV, 
#endif

#if GL_NV_PATH_RENDERING
    FontYMaxBoundsBitNv = gl.Constants.GL_FONT_Y_MAX_BOUNDS_BIT_NV, 
#endif

#if GL_NV_PATH_RENDERING
    FontUnitsPerEmBitNv = gl.Constants.GL_FONT_UNITS_PER_EM_BIT_NV, 
#endif

#if GL_NV_PATH_RENDERING
    FontAscenderBitNv = gl.Constants.GL_FONT_ASCENDER_BIT_NV, 
#endif

#if GL_NV_PATH_RENDERING
    FontDescenderBitNv = gl.Constants.GL_FONT_DESCENDER_BIT_NV, 
#endif

#if GL_NV_PATH_RENDERING
    FontHeightBitNv = gl.Constants.GL_FONT_HEIGHT_BIT_NV, 
#endif

#if GL_NV_PATH_RENDERING
    FontMaxAdvanceWidthBitNv = gl.Constants.GL_FONT_MAX_ADVANCE_WIDTH_BIT_NV, 
#endif

#if GL_NV_PATH_RENDERING
    FontMaxAdvanceHeightBitNv = gl.Constants.GL_FONT_MAX_ADVANCE_HEIGHT_BIT_NV, 
#endif

#if GL_NV_PATH_RENDERING
    FontUnderlinePositionBitNv = gl.Constants.GL_FONT_UNDERLINE_POSITION_BIT_NV, 
#endif

#if GL_NV_PATH_RENDERING
    FontUnderlineThicknessBitNv = gl.Constants.GL_FONT_UNDERLINE_THICKNESS_BIT_NV, 
#endif

#if GL_NV_PATH_RENDERING
    FontHasKerningBitNv = gl.Constants.GL_FONT_HAS_KERNING_BIT_NV, 
#endif

#if GL_NV_PATH_RENDERING
    FontNumGlyphIndicesBitNv = gl.Constants.GL_FONT_NUM_GLYPH_INDICES_BIT_NV, 
#endif

}

#endif
