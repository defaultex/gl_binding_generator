#if GL_VERSION_1_0

public enum PolygonMode : GLenum { 
#if GL_VERSION_1_0
    Point = gl.Constants.GL_POINT, 
#endif

#if GL_VERSION_1_0
    Line = gl.Constants.GL_LINE, 
#endif

#if GL_VERSION_1_0
    Fill = gl.Constants.GL_FILL, 
#endif

}

#endif
