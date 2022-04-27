#if GL_VERSION_1_0

public enum FeedBackToken : GLenum { 
#if GL_VERSION_1_0
    PassThroughToken = gl.Constants.GL_PASS_THROUGH_TOKEN, 
#endif

#if GL_VERSION_1_0
    PointToken = gl.Constants.GL_POINT_TOKEN, 
#endif

#if GL_VERSION_1_0
    LineToken = gl.Constants.GL_LINE_TOKEN, 
#endif

#if GL_VERSION_1_0
    PolygonToken = gl.Constants.GL_POLYGON_TOKEN, 
#endif

#if GL_VERSION_1_0
    BitmapToken = gl.Constants.GL_BITMAP_TOKEN, 
#endif

#if GL_VERSION_1_0
    DrawPixelToken = gl.Constants.GL_DRAW_PIXEL_TOKEN, 
#endif

#if GL_VERSION_1_0
    CopyPixelToken = gl.Constants.GL_COPY_PIXEL_TOKEN, 
#endif

#if GL_VERSION_1_0
    LineResetToken = gl.Constants.GL_LINE_RESET_TOKEN, 
#endif

}

#endif
