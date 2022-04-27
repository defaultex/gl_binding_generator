#if GL_NV_PATH_RENDERING

public enum PathCoverMode : GLenum { 
#if GL_NV_PATH_RENDERING
    FillCoverModeNv = gl.Constants.GL_PATH_FILL_COVER_MODE_NV, 
#endif

#if GL_NV_PATH_RENDERING
    ConvexHullNv = gl.Constants.GL_CONVEX_HULL_NV, 
#endif

#if GL_NV_PATH_RENDERING
    BoundingBoxNv = gl.Constants.GL_BOUNDING_BOX_NV, 
#endif

#if GL_NV_PATH_RENDERING
    BoundingBoxOfBoundingBoxesNv = gl.Constants.GL_BOUNDING_BOX_OF_BOUNDING_BOXES_NV, 
#endif

}

#endif
