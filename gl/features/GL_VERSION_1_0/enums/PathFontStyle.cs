public enum PathFontStyle : GLenum {
    None = gl.Constants.GL_NONE,
#if GL_NV_path_rendering
    BoldBitNv = gl.Constants.GL_BOLD_BIT_NV,
#endif

#if GL_NV_path_rendering
    ItalicBitNv = gl.Constants.GL_ITALIC_BIT_NV,
#endif
}
