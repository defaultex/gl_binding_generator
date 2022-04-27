#if GL_NV_PATH_RENDERING

public enum PathCoordType : GLenum { 
#if GL_NV_PATH_RENDERING
    ClosePathNv = gl.Constants.GL_CLOSE_PATH_NV, 
#endif

#if GL_NV_PATH_RENDERING
    MoveToNv = gl.Constants.GL_MOVE_TO_NV, 
#endif

#if GL_NV_PATH_RENDERING
    RelativeMoveToNv = gl.Constants.GL_RELATIVE_MOVE_TO_NV, 
#endif

#if GL_NV_PATH_RENDERING
    LineToNv = gl.Constants.GL_LINE_TO_NV, 
#endif

#if GL_NV_PATH_RENDERING
    RelativeLineToNv = gl.Constants.GL_RELATIVE_LINE_TO_NV, 
#endif

#if GL_NV_PATH_RENDERING
    HorizontalLineToNv = gl.Constants.GL_HORIZONTAL_LINE_TO_NV, 
#endif

#if GL_NV_PATH_RENDERING
    RelativeHorizontalLineToNv = gl.Constants.GL_RELATIVE_HORIZONTAL_LINE_TO_NV, 
#endif

#if GL_NV_PATH_RENDERING
    VerticalLineToNv = gl.Constants.GL_VERTICAL_LINE_TO_NV, 
#endif

#if GL_NV_PATH_RENDERING
    RelativeVerticalLineToNv = gl.Constants.GL_RELATIVE_VERTICAL_LINE_TO_NV, 
#endif

#if GL_NV_PATH_RENDERING
    QuadraticCurveToNv = gl.Constants.GL_QUADRATIC_CURVE_TO_NV, 
#endif

#if GL_NV_PATH_RENDERING
    RelativeQuadraticCurveToNv = gl.Constants.GL_RELATIVE_QUADRATIC_CURVE_TO_NV, 
#endif

#if GL_NV_PATH_RENDERING
    CubicCurveToNv = gl.Constants.GL_CUBIC_CURVE_TO_NV, 
#endif

#if GL_NV_PATH_RENDERING
    RelativeCubicCurveToNv = gl.Constants.GL_RELATIVE_CUBIC_CURVE_TO_NV, 
#endif

#if GL_NV_PATH_RENDERING
    SmoothQuadraticCurveToNv = gl.Constants.GL_SMOOTH_QUADRATIC_CURVE_TO_NV, 
#endif

#if GL_NV_PATH_RENDERING
    RelativeSmoothQuadraticCurveToNv = gl.Constants.GL_RELATIVE_SMOOTH_QUADRATIC_CURVE_TO_NV, 
#endif

#if GL_NV_PATH_RENDERING
    SmoothCubicCurveToNv = gl.Constants.GL_SMOOTH_CUBIC_CURVE_TO_NV, 
#endif

#if GL_NV_PATH_RENDERING
    RelativeSmoothCubicCurveToNv = gl.Constants.GL_RELATIVE_SMOOTH_CUBIC_CURVE_TO_NV, 
#endif

#if GL_NV_PATH_RENDERING
    SmallCcwArcToNv = gl.Constants.GL_SMALL_CCW_ARC_TO_NV, 
#endif

#if GL_NV_PATH_RENDERING
    RelativeSmallCcwArcToNv = gl.Constants.GL_RELATIVE_SMALL_CCW_ARC_TO_NV, 
#endif

#if GL_NV_PATH_RENDERING
    SmallCwArcToNv = gl.Constants.GL_SMALL_CW_ARC_TO_NV, 
#endif

#if GL_NV_PATH_RENDERING
    RelativeSmallCwArcToNv = gl.Constants.GL_RELATIVE_SMALL_CW_ARC_TO_NV, 
#endif

#if GL_NV_PATH_RENDERING
    LargeCcwArcToNv = gl.Constants.GL_LARGE_CCW_ARC_TO_NV, 
#endif

#if GL_NV_PATH_RENDERING
    RelativeLargeCcwArcToNv = gl.Constants.GL_RELATIVE_LARGE_CCW_ARC_TO_NV, 
#endif

#if GL_NV_PATH_RENDERING
    LargeCwArcToNv = gl.Constants.GL_LARGE_CW_ARC_TO_NV, 
#endif

#if GL_NV_PATH_RENDERING
    RelativeLargeCwArcToNv = gl.Constants.GL_RELATIVE_LARGE_CW_ARC_TO_NV, 
#endif

#if GL_NV_PATH_RENDERING
    ConicCurveToNv = gl.Constants.GL_CONIC_CURVE_TO_NV, 
#endif

#if GL_NV_PATH_RENDERING
    RelativeConicCurveToNv = gl.Constants.GL_RELATIVE_CONIC_CURVE_TO_NV, 
#endif

#if GL_NV_PATH_RENDERING
    RoundedRectNv = gl.Constants.GL_ROUNDED_RECT_NV, 
#endif

#if GL_NV_PATH_RENDERING
    RelativeRoundedRectNv = gl.Constants.GL_RELATIVE_ROUNDED_RECT_NV, 
#endif

#if GL_NV_PATH_RENDERING
    RoundedRect2Nv = gl.Constants.GL_ROUNDED_RECT2_NV, 
#endif

#if GL_NV_PATH_RENDERING
    RelativeRoundedRect2Nv = gl.Constants.GL_RELATIVE_ROUNDED_RECT2_NV, 
#endif

#if GL_NV_PATH_RENDERING
    RoundedRect4Nv = gl.Constants.GL_ROUNDED_RECT4_NV, 
#endif

#if GL_NV_PATH_RENDERING
    RelativeRoundedRect4Nv = gl.Constants.GL_RELATIVE_ROUNDED_RECT4_NV, 
#endif

#if GL_NV_PATH_RENDERING
    RoundedRect8Nv = gl.Constants.GL_ROUNDED_RECT8_NV, 
#endif

#if GL_NV_PATH_RENDERING
    RelativeRoundedRect8Nv = gl.Constants.GL_RELATIVE_ROUNDED_RECT8_NV, 
#endif

#if GL_NV_PATH_RENDERING
    RestartPathNv = gl.Constants.GL_RESTART_PATH_NV, 
#endif

#if GL_NV_PATH_RENDERING
    DupFirstCubicCurveToNv = gl.Constants.GL_DUP_FIRST_CUBIC_CURVE_TO_NV, 
#endif

#if GL_NV_PATH_RENDERING
    DupLastCubicCurveToNv = gl.Constants.GL_DUP_LAST_CUBIC_CURVE_TO_NV, 
#endif

#if GL_NV_PATH_RENDERING
    RectNv = gl.Constants.GL_RECT_NV, 
#endif

#if GL_NV_PATH_RENDERING
    RelativeRectNv = gl.Constants.GL_RELATIVE_RECT_NV, 
#endif

#if GL_NV_PATH_RENDERING
    CircularCcwArcToNv = gl.Constants.GL_CIRCULAR_CCW_ARC_TO_NV, 
#endif

#if GL_NV_PATH_RENDERING
    CircularCwArcToNv = gl.Constants.GL_CIRCULAR_CW_ARC_TO_NV, 
#endif

#if GL_NV_PATH_RENDERING
    CircularTangentArcToNv = gl.Constants.GL_CIRCULAR_TANGENT_ARC_TO_NV, 
#endif

#if GL_NV_PATH_RENDERING
    ArcToNv = gl.Constants.GL_ARC_TO_NV, 
#endif

#if GL_NV_PATH_RENDERING
    RelativeArcToNv = gl.Constants.GL_RELATIVE_ARC_TO_NV, 
#endif

}

#endif
