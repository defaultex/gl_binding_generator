[Flags]
public enum AttribMask : GLbitfield {
    DepthBuffer = gl.Constants.GL_DEPTH_BUFFER_BIT,
    StencilBuffer = gl.Constants.GL_STENCIL_BUFFER_BIT,
    ColorBuffer = gl.Constants.GL_COLOR_BUFFER_BIT,
}
