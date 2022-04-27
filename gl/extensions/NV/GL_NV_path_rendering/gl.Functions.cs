#if (GL_NV_path_rendering && (GL_API || GLCORE_API || GLES2_API))
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glCopyPathNV(GLuint resultPath, GLuint srcPath)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint, void> glCopyPathNV;

        /// <summary>void glCoverFillPathInstancedNV(GLsizei numPaths, GLenum pathNameType, const void* paths, GLuint pathBase, GLenum coverMode, GLenum transformType, const GLfloat* transformValues)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, PathElementType, void*, GLuint, PathCoverMode, PathTransformType, GLfloat*, void> glCoverFillPathInstancedNV;

        /// <summary>void glCoverFillPathNV(GLuint path, GLenum coverMode)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, PathCoverMode, void> glCoverFillPathNV;

        /// <summary>void glCoverStrokePathInstancedNV(GLsizei numPaths, GLenum pathNameType, const void* paths, GLuint pathBase, GLenum coverMode, GLenum transformType, const GLfloat* transformValues)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, PathElementType, void*, GLuint, PathCoverMode, PathTransformType, GLfloat*, void> glCoverStrokePathInstancedNV;

        /// <summary>void glCoverStrokePathNV(GLuint path, GLenum coverMode)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, PathCoverMode, void> glCoverStrokePathNV;

        /// <summary>void glDeletePathsNV(GLuint path, GLsizei range)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLsizei, void> glDeletePathsNV;

        /// <summary>GLuint glGenPathsNV(GLsizei range)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLuint> glGenPathsNV;

        /// <summary>void glGetPathColorGenfvNV(GLenum color, GLenum pname, GLfloat* value)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PathColor, PathGenMode, GLfloat*, void> glGetPathColorGenfvNV;

        /// <summary>void glGetPathColorGenivNV(GLenum color, GLenum pname, GLint* value)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PathColor, PathGenMode, GLint*, void> glGetPathColorGenivNV;

        /// <summary>void glGetPathCommandsNV(GLuint path, GLubyte* commands)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLubyte*, void> glGetPathCommandsNV;

        /// <summary>void glGetPathCoordsNV(GLuint path, GLfloat* coords)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLfloat*, void> glGetPathCoordsNV;

        /// <summary>void glGetPathDashArrayNV(GLuint path, GLfloat* dashArray)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLfloat*, void> glGetPathDashArrayNV;

        /// <summary>GLfloat glGetPathLengthNV(GLuint path, GLsizei startSegment, GLsizei numSegments)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLsizei, GLsizei, GLfloat> glGetPathLengthNV;

        /// <summary>void glGetPathMetricRangeNV(GLbitfield metricQueryMask, GLuint firstPathName, GLsizei numPaths, GLsizei stride, GLfloat* metrics)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PathMetricMask, GLuint, GLsizei, GLsizei, GLfloat*, void> glGetPathMetricRangeNV;

        /// <summary>void glGetPathMetricsNV(GLbitfield metricQueryMask, GLsizei numPaths, GLenum pathNameType, const void* paths, GLuint pathBase, GLsizei stride, GLfloat* metrics)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PathMetricMask, GLsizei, PathElementType, void*, GLuint, GLsizei, GLfloat*, void> glGetPathMetricsNV;

        /// <summary>void glGetPathParameterfvNV(GLuint path, GLenum pname, GLfloat* value)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, PathParameter, GLfloat*, void> glGetPathParameterfvNV;

        /// <summary>void glGetPathParameterivNV(GLuint path, GLenum pname, GLint* value)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, PathParameter, GLint*, void> glGetPathParameterivNV;

        /// <summary>void glGetPathSpacingNV(GLenum pathListMode, GLsizei numPaths, GLenum pathNameType, const void* paths, GLuint pathBase, GLfloat advanceScale, GLfloat kerningScale, GLenum transformType, GLfloat* returnedSpacing)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PathListMode, GLsizei, PathElementType, void*, GLuint, GLfloat, GLfloat, PathTransformType, GLfloat*, void> glGetPathSpacingNV;

        /// <summary>void glGetPathTexGenfvNV(GLenum texCoordSet, GLenum pname, GLfloat* value)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, PathGenMode, GLfloat*, void> glGetPathTexGenfvNV;

        /// <summary>void glGetPathTexGenivNV(GLenum texCoordSet, GLenum pname, GLint* value)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, PathGenMode, GLint*, void> glGetPathTexGenivNV;

        /// <summary>void glGetProgramResourcefvNV(GLuint program, GLenum programInterface, GLuint index, GLsizei propCount, const GLenum* props, GLsizei count, GLsizei* length, GLfloat* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, ProgramInterface, GLuint, GLsizei, GLenum*, GLsizei, GLsizei*, GLfloat*, void> glGetProgramResourcefvNV;

        /// <summary>void glInterpolatePathsNV(GLuint resultPath, GLuint pathA, GLuint pathB, GLfloat weight)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint, GLuint, GLfloat, void> glInterpolatePathsNV;

        /// <summary>GLboolean glIsPathNV(GLuint path)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLboolean> glIsPathNV;

        /// <summary>GLboolean glIsPointInFillPathNV(GLuint path, GLuint mask, GLfloat x, GLfloat y)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint, GLfloat, GLfloat, GLboolean> glIsPointInFillPathNV;

        /// <summary>GLboolean glIsPointInStrokePathNV(GLuint path, GLfloat x, GLfloat y)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLfloat, GLfloat, GLboolean> glIsPointInStrokePathNV;

        /// <summary>void glMatrixFrustumEXT(GLenum mode, GLdouble left, GLdouble right, GLdouble bottom, GLdouble top, GLdouble zNear, GLdouble zFar)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MatrixMode, GLdouble, GLdouble, GLdouble, GLdouble, GLdouble, GLdouble, void> glMatrixFrustumEXT;

        /// <summary>void glMatrixLoad3x2fNV(GLenum matrixMode, const GLfloat* m)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, GLfloat*, void> glMatrixLoad3x2fNV;

        /// <summary>void glMatrixLoad3x3fNV(GLenum matrixMode, const GLfloat* m)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, GLfloat*, void> glMatrixLoad3x3fNV;

        /// <summary>void glMatrixLoadIdentityEXT(GLenum mode)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MatrixMode, void> glMatrixLoadIdentityEXT;

        /// <summary>void glMatrixLoadTranspose3x3fNV(GLenum matrixMode, const GLfloat* m)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, GLfloat*, void> glMatrixLoadTranspose3x3fNV;

        /// <summary>void glMatrixLoadTransposedEXT(GLenum mode, const GLdouble* m)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MatrixMode, GLdouble*, void> glMatrixLoadTransposedEXT;

        /// <summary>void glMatrixLoadTransposefEXT(GLenum mode, const GLfloat* m)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MatrixMode, GLfloat*, void> glMatrixLoadTransposefEXT;

        /// <summary>void glMatrixLoaddEXT(GLenum mode, const GLdouble* m)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MatrixMode, GLdouble*, void> glMatrixLoaddEXT;

        /// <summary>void glMatrixLoadfEXT(GLenum mode, const GLfloat* m)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MatrixMode, GLfloat*, void> glMatrixLoadfEXT;

        /// <summary>void glMatrixMult3x2fNV(GLenum matrixMode, const GLfloat* m)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, GLfloat*, void> glMatrixMult3x2fNV;

        /// <summary>void glMatrixMult3x3fNV(GLenum matrixMode, const GLfloat* m)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, GLfloat*, void> glMatrixMult3x3fNV;

        /// <summary>void glMatrixMultTranspose3x3fNV(GLenum matrixMode, const GLfloat* m)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, GLfloat*, void> glMatrixMultTranspose3x3fNV;

        /// <summary>void glMatrixMultTransposedEXT(GLenum mode, const GLdouble* m)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MatrixMode, GLdouble*, void> glMatrixMultTransposedEXT;

        /// <summary>void glMatrixMultTransposefEXT(GLenum mode, const GLfloat* m)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MatrixMode, GLfloat*, void> glMatrixMultTransposefEXT;

        /// <summary>void glMatrixMultdEXT(GLenum mode, const GLdouble* m)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MatrixMode, GLdouble*, void> glMatrixMultdEXT;

        /// <summary>void glMatrixMultfEXT(GLenum mode, const GLfloat* m)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MatrixMode, GLfloat*, void> glMatrixMultfEXT;

        /// <summary>void glMatrixOrthoEXT(GLenum mode, GLdouble left, GLdouble right, GLdouble bottom, GLdouble top, GLdouble zNear, GLdouble zFar)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MatrixMode, GLdouble, GLdouble, GLdouble, GLdouble, GLdouble, GLdouble, void> glMatrixOrthoEXT;

        /// <summary>void glMatrixPopEXT(GLenum mode)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MatrixMode, void> glMatrixPopEXT;

        /// <summary>void glMatrixPushEXT(GLenum mode)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MatrixMode, void> glMatrixPushEXT;

        /// <summary>void glMatrixRotatedEXT(GLenum mode, GLdouble angle, GLdouble x, GLdouble y, GLdouble z)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MatrixMode, GLdouble, GLdouble, GLdouble, GLdouble, void> glMatrixRotatedEXT;

        /// <summary>void glMatrixRotatefEXT(GLenum mode, GLfloat angle, GLfloat x, GLfloat y, GLfloat z)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MatrixMode, GLfloat, GLfloat, GLfloat, GLfloat, void> glMatrixRotatefEXT;

        /// <summary>void glMatrixScaledEXT(GLenum mode, GLdouble x, GLdouble y, GLdouble z)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MatrixMode, GLdouble, GLdouble, GLdouble, void> glMatrixScaledEXT;

        /// <summary>void glMatrixScalefEXT(GLenum mode, GLfloat x, GLfloat y, GLfloat z)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MatrixMode, GLfloat, GLfloat, GLfloat, void> glMatrixScalefEXT;

        /// <summary>void glMatrixTranslatedEXT(GLenum mode, GLdouble x, GLdouble y, GLdouble z)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MatrixMode, GLdouble, GLdouble, GLdouble, void> glMatrixTranslatedEXT;

        /// <summary>void glMatrixTranslatefEXT(GLenum mode, GLfloat x, GLfloat y, GLfloat z)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MatrixMode, GLfloat, GLfloat, GLfloat, void> glMatrixTranslatefEXT;

        /// <summary>void glPathColorGenNV(GLenum color, GLenum genMode, GLenum colorFormat, const GLfloat* coeffs)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PathColor, PathGenMode, PathColorFormat, GLfloat*, void> glPathColorGenNV;

        /// <summary>void glPathCommandsNV(GLuint path, GLsizei numCommands, const GLubyte* commands, GLsizei numCoords, GLenum coordType, const void* coords)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLsizei, GLubyte*, GLsizei, PathCoordType, void*, void> glPathCommandsNV;

        /// <summary>void glPathCoordsNV(GLuint path, GLsizei numCoords, GLenum coordType, const void* coords)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLsizei, PathCoordType, void*, void> glPathCoordsNV;

        /// <summary>void glPathCoverDepthFuncNV(GLenum func)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<DepthFunction, void> glPathCoverDepthFuncNV;

        /// <summary>void glPathDashArrayNV(GLuint path, GLsizei dashCount, const GLfloat* dashArray)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLsizei, GLfloat*, void> glPathDashArrayNV;

        /// <summary>void glPathFogGenNV(GLenum genMode)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PathGenMode, void> glPathFogGenNV;

        /// <summary>GLenum glPathGlyphIndexArrayNV(GLuint firstPathName, GLenum fontTarget, const void* fontName, GLbitfield fontStyle, GLuint firstGlyphIndex, GLsizei numGlyphs, GLuint pathParameterTemplate, GLfloat emScale)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLenum, void*, PathFontStyle, GLuint, GLsizei, GLuint, GLfloat, GLenum> glPathGlyphIndexArrayNV;

        /// <summary>GLenum glPathGlyphIndexRangeNV(GLenum fontTarget, const void* fontName, GLbitfield fontStyle, GLuint pathParameterTemplate, GLfloat emScale, GLuint* baseAndCount)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, void*, PathFontStyle, GLuint, GLfloat, GLuint*, GLenum> glPathGlyphIndexRangeNV;

        /// <summary>void glPathGlyphRangeNV(GLuint firstPathName, GLenum fontTarget, const void* fontName, GLbitfield fontStyle, GLuint firstGlyph, GLsizei numGlyphs, GLenum handleMissingGlyphs, GLuint pathParameterTemplate, GLfloat emScale)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, PathFontTarget, void*, PathFontStyle, GLuint, GLsizei, PathHandleMissingGlyphs, GLuint, GLfloat, void> glPathGlyphRangeNV;

        /// <summary>void glPathGlyphsNV(GLuint firstPathName, GLenum fontTarget, const void* fontName, GLbitfield fontStyle, GLsizei numGlyphs, GLenum type, const void* charcodes, GLenum handleMissingGlyphs, GLuint pathParameterTemplate, GLfloat emScale)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, PathFontTarget, void*, PathFontStyle, GLsizei, PathElementType, void*, PathHandleMissingGlyphs, GLuint, GLfloat, void> glPathGlyphsNV;

        /// <summary>GLenum glPathMemoryGlyphIndexArrayNV(GLuint firstPathName, GLenum fontTarget, GLsizeiptr fontSize, const void* fontData, GLsizei faceIndex, GLuint firstGlyphIndex, GLsizei numGlyphs, GLuint pathParameterTemplate, GLfloat emScale)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLenum, GLsizeiptr, void*, GLsizei, GLuint, GLsizei, GLuint, GLfloat, GLenum> glPathMemoryGlyphIndexArrayNV;

        /// <summary>void glPathParameterfNV(GLuint path, GLenum pname, GLfloat value)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, PathParameter, GLfloat, void> glPathParameterfNV;

        /// <summary>void glPathParameterfvNV(GLuint path, GLenum pname, const GLfloat* value)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, PathParameter, GLfloat*, void> glPathParameterfvNV;

        /// <summary>void glPathParameteriNV(GLuint path, GLenum pname, GLint value)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, PathParameter, GLint, void> glPathParameteriNV;

        /// <summary>void glPathParameterivNV(GLuint path, GLenum pname, const GLint* value)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, PathParameter, GLint*, void> glPathParameterivNV;

        /// <summary>void glPathStencilDepthOffsetNV(GLfloat factor, GLfloat units)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLfloat, void> glPathStencilDepthOffsetNV;

        /// <summary>void glPathStencilFuncNV(GLenum func, GLint ref, GLuint mask)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<StencilFunction, GLint, GLuint, void> glPathStencilFuncNV;

        /// <summary>void glPathStringNV(GLuint path, GLenum format, GLsizei length, const void* pathString)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, PathStringFormat, GLsizei, void*, void> glPathStringNV;

        /// <summary>void glPathSubCommandsNV(GLuint path, GLsizei commandStart, GLsizei commandsToDelete, GLsizei numCommands, const GLubyte* commands, GLsizei numCoords, GLenum coordType, const void* coords)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLsizei, GLsizei, GLsizei, GLubyte*, GLsizei, PathCoordType, void*, void> glPathSubCommandsNV;

        /// <summary>void glPathSubCoordsNV(GLuint path, GLsizei coordStart, GLsizei numCoords, GLenum coordType, const void* coords)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLsizei, GLsizei, PathCoordType, void*, void> glPathSubCoordsNV;

        /// <summary>void glPathTexGenNV(GLenum texCoordSet, GLenum genMode, GLint components, const GLfloat* coeffs)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PathColor, PathGenMode, GLint, GLfloat*, void> glPathTexGenNV;

        /// <summary>GLboolean glPointAlongPathNV(GLuint path, GLsizei startSegment, GLsizei numSegments, GLfloat distance, GLfloat* x, GLfloat* y, GLfloat* tangentX, GLfloat* tangentY)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLsizei, GLsizei, GLfloat, GLfloat*, GLfloat*, GLfloat*, GLfloat*, GLboolean> glPointAlongPathNV;

        /// <summary>void glProgramPathFragmentInputGenNV(GLuint program, GLint location, GLenum genMode, GLint components, const GLfloat* coeffs)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLenum, GLint, GLfloat*, void> glProgramPathFragmentInputGenNV;

        /// <summary>void glStencilFillPathInstancedNV(GLsizei numPaths, GLenum pathNameType, const void* paths, GLuint pathBase, GLenum fillMode, GLuint mask, GLenum transformType, const GLfloat* transformValues)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, PathElementType, void*, GLuint, PathFillMode, GLuint, PathTransformType, GLfloat*, void> glStencilFillPathInstancedNV;

        /// <summary>void glStencilFillPathNV(GLuint path, GLenum fillMode, GLuint mask)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, PathFillMode, GLuint, void> glStencilFillPathNV;

        /// <summary>void glStencilStrokePathInstancedNV(GLsizei numPaths, GLenum pathNameType, const void* paths, GLuint pathBase, GLint reference, GLuint mask, GLenum transformType, const GLfloat* transformValues)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, PathElementType, void*, GLuint, GLint, GLuint, PathTransformType, GLfloat*, void> glStencilStrokePathInstancedNV;

        /// <summary>void glStencilStrokePathNV(GLuint path, GLint reference, GLuint mask)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLint, GLuint, void> glStencilStrokePathNV;

        /// <summary>void glStencilThenCoverFillPathInstancedNV(GLsizei numPaths, GLenum pathNameType, const void* paths, GLuint pathBase, GLenum fillMode, GLuint mask, GLenum coverMode, GLenum transformType, const GLfloat* transformValues)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLenum, void*, GLuint, GLenum, GLuint, GLenum, GLenum, GLfloat*, void> glStencilThenCoverFillPathInstancedNV;

        /// <summary>void glStencilThenCoverFillPathNV(GLuint path, GLenum fillMode, GLuint mask, GLenum coverMode)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLenum, GLuint, GLenum, void> glStencilThenCoverFillPathNV;

        /// <summary>void glStencilThenCoverStrokePathInstancedNV(GLsizei numPaths, GLenum pathNameType, const void* paths, GLuint pathBase, GLint reference, GLuint mask, GLenum coverMode, GLenum transformType, const GLfloat* transformValues)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLenum, void*, GLuint, GLint, GLuint, GLenum, GLenum, GLfloat*, void> glStencilThenCoverStrokePathInstancedNV;

        /// <summary>void glStencilThenCoverStrokePathNV(GLuint path, GLint reference, GLuint mask, GLenum coverMode)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLint, GLuint, GLenum, void> glStencilThenCoverStrokePathNV;

        /// <summary>void glTransformPathNV(GLuint resultPath, GLuint srcPath, GLenum transformType, const GLfloat* transformValues)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint, PathTransformType, GLfloat*, void> glTransformPathNV;

        /// <summary>void glWeightPathsNV(GLuint resultPath, GLsizei numPaths, const GLuint* paths, const GLfloat* weights)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLsizei, GLuint*, GLfloat*, void> glWeightPathsNV;
    }
}
#endif