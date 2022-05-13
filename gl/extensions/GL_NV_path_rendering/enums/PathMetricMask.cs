#if GL_NV_path_rendering

[Flags]
public enum PathMetricMask : GLbitfield {
#if GL_NV_path_rendering
    GlyphWidthBitNv = gl.Constants.GL_GLYPH_WIDTH_BIT_NV,
#endif

#if GL_NV_path_rendering
    GlyphHeightBitNv = gl.Constants.GL_GLYPH_HEIGHT_BIT_NV,
#endif

#if GL_NV_path_rendering
    GlyphHorizontalBearingXBitNv = gl.Constants.GL_GLYPH_HORIZONTAL_BEARING_X_BIT_NV,
#endif

#if GL_NV_path_rendering
    GlyphHorizontalBearingYBitNv = gl.Constants.GL_GLYPH_HORIZONTAL_BEARING_Y_BIT_NV,
#endif

#if GL_NV_path_rendering
    GlyphHorizontalBearingAdvanceBitNv = gl.Constants.GL_GLYPH_HORIZONTAL_BEARING_ADVANCE_BIT_NV,
#endif

#if GL_NV_path_rendering
    GlyphVerticalBearingXBitNv = gl.Constants.GL_GLYPH_VERTICAL_BEARING_X_BIT_NV,
#endif

#if GL_NV_path_rendering
    GlyphVerticalBearingYBitNv = gl.Constants.GL_GLYPH_VERTICAL_BEARING_Y_BIT_NV,
#endif

#if GL_NV_path_rendering
    GlyphVerticalBearingAdvanceBitNv = gl.Constants.GL_GLYPH_VERTICAL_BEARING_ADVANCE_BIT_NV,
#endif

#if GL_NV_path_rendering
    GlyphHasKerningBitNv = gl.Constants.GL_GLYPH_HAS_KERNING_BIT_NV,
#endif

#if GL_NV_path_rendering
    FontXMinBoundsBitNv = gl.Constants.GL_FONT_X_MIN_BOUNDS_BIT_NV,
#endif

#if GL_NV_path_rendering
    FontYMinBoundsBitNv = gl.Constants.GL_FONT_Y_MIN_BOUNDS_BIT_NV,
#endif

#if GL_NV_path_rendering
    FontXMaxBoundsBitNv = gl.Constants.GL_FONT_X_MAX_BOUNDS_BIT_NV,
#endif

#if GL_NV_path_rendering
    FontYMaxBoundsBitNv = gl.Constants.GL_FONT_Y_MAX_BOUNDS_BIT_NV,
#endif

#if GL_NV_path_rendering
    FontUnitsPerEmBitNv = gl.Constants.GL_FONT_UNITS_PER_EM_BIT_NV,
#endif

#if GL_NV_path_rendering
    FontAscenderBitNv = gl.Constants.GL_FONT_ASCENDER_BIT_NV,
#endif

#if GL_NV_path_rendering
    FontDescenderBitNv = gl.Constants.GL_FONT_DESCENDER_BIT_NV,
#endif

#if GL_NV_path_rendering
    FontHeightBitNv = gl.Constants.GL_FONT_HEIGHT_BIT_NV,
#endif

#if GL_NV_path_rendering
    FontMaxAdvanceWidthBitNv = gl.Constants.GL_FONT_MAX_ADVANCE_WIDTH_BIT_NV,
#endif

#if GL_NV_path_rendering
    FontMaxAdvanceHeightBitNv = gl.Constants.GL_FONT_MAX_ADVANCE_HEIGHT_BIT_NV,
#endif

#if GL_NV_path_rendering
    FontUnderlinePositionBitNv = gl.Constants.GL_FONT_UNDERLINE_POSITION_BIT_NV,
#endif

#if GL_NV_path_rendering
    FontUnderlineThicknessBitNv = gl.Constants.GL_FONT_UNDERLINE_THICKNESS_BIT_NV,
#endif

#if GL_NV_path_rendering
    FontHasKerningBitNv = gl.Constants.GL_FONT_HAS_KERNING_BIT_NV,
#endif

#if GL_NV_path_rendering
    FontNumGlyphIndicesBitNv = gl.Constants.GL_FONT_NUM_GLYPH_INDICES_BIT_NV,
#endif
}

#endif