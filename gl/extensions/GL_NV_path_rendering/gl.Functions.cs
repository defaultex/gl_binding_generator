#if GL_NV_path_rendering

public partial class gl { 
    public partial class Functions { 
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint, void> glCopyPathNV;
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, PathElementType, void*, GLuint, PathCoverMode, PathTransformType, GLfloat*, void> glCoverFillPathInstancedNV;
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, PathCoverMode, void> glCoverFillPathNV;
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, PathElementType, void*, GLuint, PathCoverMode, PathTransformType, GLfloat*, void> glCoverStrokePathInstancedNV;
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, PathCoverMode, void> glCoverStrokePathNV;
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLsizei, void> glDeletePathsNV;
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLuint> glGenPathsNV;
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLubyte*, void> glGetPathCommandsNV;
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLfloat*, void> glGetPathCoordsNV;
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLfloat*, void> glGetPathDashArrayNV;
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLsizei, GLsizei, GLfloat> glGetPathLengthNV;
        public static unsafe delegate* unmanaged[Cdecl]<PathMetricMask, GLuint, GLsizei, GLsizei, GLfloat*, void> glGetPathMetricRangeNV;
        public static unsafe delegate* unmanaged[Cdecl]<PathMetricMask, GLsizei, PathElementType, void*, GLuint, GLsizei, GLfloat*, void> glGetPathMetricsNV;
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, PathParameter, GLfloat*, void> glGetPathParameterfvNV;
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, PathParameter, GLint*, void> glGetPathParameterivNV;
        public static unsafe delegate* unmanaged[Cdecl]<PathListMode, GLsizei, PathElementType, void*, GLuint, GLfloat, GLfloat, PathTransformType, GLfloat*, void> glGetPathSpacingNV;
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, ProgramInterface, GLuint, GLsizei, GLenum*, GLsizei, GLsizei*, GLfloat*, void> glGetProgramResourcefvNV;
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint, GLuint, GLfloat, void> glInterpolatePathsNV;
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLboolean> glIsPathNV;
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint, GLfloat, GLfloat, GLboolean> glIsPointInFillPathNV;
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLfloat, GLfloat, GLboolean> glIsPointInStrokePathNV;
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, GLfloat*, void> glMatrixLoad3x2fNV;
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, GLfloat*, void> glMatrixLoad3x3fNV;
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, GLfloat*, void> glMatrixLoadTranspose3x3fNV;
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, GLfloat*, void> glMatrixMult3x2fNV;
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, GLfloat*, void> glMatrixMult3x3fNV;
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, GLfloat*, void> glMatrixMultTranspose3x3fNV;
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLsizei, GLubyte*, GLsizei, PathCoordType, void*, void> glPathCommandsNV;
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLsizei, PathCoordType, void*, void> glPathCoordsNV;
        public static unsafe delegate* unmanaged[Cdecl]<DepthFunction, void> glPathCoverDepthFuncNV;
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLsizei, GLfloat*, void> glPathDashArrayNV;
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLenum, void*, PathFontStyle, GLuint, GLsizei, GLuint, GLfloat, GLenum> glPathGlyphIndexArrayNV;
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, void*, PathFontStyle, GLuint, GLfloat, GLuint*, GLenum> glPathGlyphIndexRangeNV;
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, PathFontTarget, void*, PathFontStyle, GLuint, GLsizei, PathHandleMissingGlyphs, GLuint, GLfloat, void> glPathGlyphRangeNV;
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, PathFontTarget, void*, PathFontStyle, GLsizei, PathElementType, void*, PathHandleMissingGlyphs, GLuint, GLfloat, void> glPathGlyphsNV;
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLenum, GLsizeiptr, void*, GLsizei, GLuint, GLsizei, GLuint, GLfloat, GLenum> glPathMemoryGlyphIndexArrayNV;
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, PathParameter, GLfloat, void> glPathParameterfNV;
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, PathParameter, GLfloat*, void> glPathParameterfvNV;
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, PathParameter, GLint, void> glPathParameteriNV;
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, PathParameter, GLint*, void> glPathParameterivNV;
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLfloat, void> glPathStencilDepthOffsetNV;
        public static unsafe delegate* unmanaged[Cdecl]<StencilFunction, GLint, GLuint, void> glPathStencilFuncNV;
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, PathStringFormat, GLsizei, void*, void> glPathStringNV;
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLsizei, GLsizei, GLsizei, GLubyte*, GLsizei, PathCoordType, void*, void> glPathSubCommandsNV;
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLsizei, GLsizei, PathCoordType, void*, void> glPathSubCoordsNV;
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLsizei, GLsizei, GLfloat, GLfloat*, GLfloat*, GLfloat*, GLfloat*, GLboolean> glPointAlongPathNV;
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLenum, GLint, GLfloat*, void> glProgramPathFragmentInputGenNV;
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, PathElementType, void*, GLuint, PathFillMode, GLuint, PathTransformType, GLfloat*, void> glStencilFillPathInstancedNV;
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, PathFillMode, GLuint, void> glStencilFillPathNV;
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, PathElementType, void*, GLuint, GLint, GLuint, PathTransformType, GLfloat*, void> glStencilStrokePathInstancedNV;
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLint, GLuint, void> glStencilStrokePathNV;
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLenum, void*, GLuint, GLenum, GLuint, GLenum, GLenum, GLfloat*, void> glStencilThenCoverFillPathInstancedNV;
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLenum, GLuint, GLenum, void> glStencilThenCoverFillPathNV;
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLenum, void*, GLuint, GLint, GLuint, GLenum, GLenum, GLfloat*, void> glStencilThenCoverStrokePathInstancedNV;
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLint, GLuint, GLenum, void> glStencilThenCoverStrokePathNV;
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint, PathTransformType, GLfloat*, void> glTransformPathNV;
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLsizei, GLuint*, GLfloat*, void> glWeightPathsNV;
    }
}

#endif