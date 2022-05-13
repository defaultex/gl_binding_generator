public enum PathGenMode : GLenum {
    None = gl.Constants.GL_NONE,
#if GL_NV_path_rendering
    PathObjectBoundingBoxNv = gl.Constants.GL_PATH_OBJECT_BOUNDING_BOX_NV,
#endif
}
