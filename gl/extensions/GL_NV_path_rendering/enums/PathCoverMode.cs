#if GL_NV_path_rendering

public enum PathCoverMode : GLenum {
#if GL_NV_path_rendering
    PathFillCoverModeNv = gl.Constants.GL_PATH_FILL_COVER_MODE_NV,
#endif

#if GL_NV_path_rendering
    ConvexHullNv = gl.Constants.GL_CONVEX_HULL_NV,
#endif

#if GL_NV_path_rendering
    BoundingBoxNv = gl.Constants.GL_BOUNDING_BOX_NV,
#endif

#if GL_NV_path_rendering
    BoundingBoxOfBoundingBoxesNv = gl.Constants.GL_BOUNDING_BOX_OF_BOUNDING_BOXES_NV,
#endif
}

#endif