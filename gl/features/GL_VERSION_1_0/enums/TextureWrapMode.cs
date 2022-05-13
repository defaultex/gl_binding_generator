public enum TextureWrapMode : GLenum {
    LinearMipmapLinear = gl.Constants.GL_LINEAR_MIPMAP_LINEAR,
    Repeat = gl.Constants.GL_REPEAT,
    ClampToEdge = gl.Constants.GL_CLAMP_TO_EDGE,
    ClampToBorder = gl.Constants.GL_CLAMP_TO_BORDER,
    MirroredRepeat = gl.Constants.GL_MIRRORED_REPEAT,
#if GL_ARB_texture_border_clamp
    ClampToBorderArb = gl.Constants.GL_CLAMP_TO_BORDER_ARB,
#endif
}
