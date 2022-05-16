public enum MinFilter : GLenum {
    Nearest = gl.Constants.GL_NEAREST,
    Linear = gl.Constants.GL_LINEAR,
    NearestMipmapNearest = gl.Constants.GL_NEAREST_MIPMAP_NEAREST,
    LinearMipmapNearest = gl.Constants.GL_LINEAR_MIPMAP_NEAREST,
    NearestMipmapLinear = gl.Constants.GL_NEAREST_MIPMAP_LINEAR,
    LinearMipmapLinear = gl.Constants.GL_LINEAR_MIPMAP_LINEAR,
}
