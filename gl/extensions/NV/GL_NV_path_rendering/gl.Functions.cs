#if (GL_NV_path_rendering && (GL_API || GLCORE_API || GLES2_API))
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glCopyPathNV(GLuint resultPath, GLuint srcPath);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint, void> glCopyPathNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glCoverFillPathInstancedNV(GLsizei numPaths, GLenum pathNameType, void* paths, GLuint pathBase, GLenum coverMode, GLenum transformType, GLfloat* transformValues);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, PathElementType, void*, GLuint, PathCoverMode, PathTransformType, GLfloat*, void> glCoverFillPathInstancedNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glCoverFillPathNV(GLuint path, GLenum coverMode);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, PathCoverMode, void> glCoverFillPathNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glCoverStrokePathInstancedNV(GLsizei numPaths, GLenum pathNameType, void* paths, GLuint pathBase, GLenum coverMode, GLenum transformType, GLfloat* transformValues);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, PathElementType, void*, GLuint, PathCoverMode, PathTransformType, GLfloat*, void> glCoverStrokePathInstancedNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glCoverStrokePathNV(GLuint path, GLenum coverMode);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, PathCoverMode, void> glCoverStrokePathNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glDeletePathsNV(GLuint path, GLsizei range);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLsizei, void> glDeletePathsNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>GLuint glGenPathsNV(GLsizei range);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLuint> glGenPathsNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetPathColorGenfvNV(GLenum color, GLenum pname, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PathColor, PathGenMode, GLfloat*, void> glGetPathColorGenfvNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetPathColorGenivNV(GLenum color, GLenum pname, GLint* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PathColor, PathGenMode, GLint*, void> glGetPathColorGenivNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetPathCommandsNV(GLuint path, GLubyte* commands);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLubyte*, void> glGetPathCommandsNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetPathCoordsNV(GLuint path, GLfloat* coords);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLfloat*, void> glGetPathCoordsNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetPathDashArrayNV(GLuint path, GLfloat* dashArray);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLfloat*, void> glGetPathDashArrayNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>GLfloat glGetPathLengthNV(GLuint path, GLsizei startSegment, GLsizei numSegments);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLsizei, GLsizei, GLfloat> glGetPathLengthNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetPathMetricRangeNV(GLbitfield metricQueryMask, GLuint firstPathName, GLsizei numPaths, GLsizei stride, GLfloat* metrics);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PathMetricMask, GLuint, GLsizei, GLsizei, GLfloat*, void> glGetPathMetricRangeNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetPathMetricsNV(GLbitfield metricQueryMask, GLsizei numPaths, GLenum pathNameType, void* paths, GLuint pathBase, GLsizei stride, GLfloat* metrics);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PathMetricMask, GLsizei, PathElementType, void*, GLuint, GLsizei, GLfloat*, void> glGetPathMetricsNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetPathParameterfvNV(GLuint path, GLenum pname, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, PathParameter, GLfloat*, void> glGetPathParameterfvNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetPathParameterivNV(GLuint path, GLenum pname, GLint* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, PathParameter, GLint*, void> glGetPathParameterivNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetPathSpacingNV(GLenum pathListMode, GLsizei numPaths, GLenum pathNameType, void* paths, GLuint pathBase, GLfloat advanceScale, GLfloat kerningScale, GLenum transformType, GLfloat* returnedSpacing);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PathListMode, GLsizei, PathElementType, void*, GLuint, GLfloat, GLfloat, PathTransformType, GLfloat*, void> glGetPathSpacingNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetPathTexGenfvNV(GLenum texCoordSet, GLenum pname, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, PathGenMode, GLfloat*, void> glGetPathTexGenfvNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetPathTexGenivNV(GLenum texCoordSet, GLenum pname, GLint* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, PathGenMode, GLint*, void> glGetPathTexGenivNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetProgramResourcefvNV(GLuint program, GLenum programInterface, GLuint index, GLsizei propCount, GLenum* props, GLsizei count, GLsizei* length, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, ProgramInterface, GLuint, GLsizei, GLenum*, GLsizei, GLsizei*, GLfloat*, void> glGetProgramResourcefvNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glInterpolatePathsNV(GLuint resultPath, GLuint pathA, GLuint pathB, GLfloat weight);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint, GLuint, GLfloat, void> glInterpolatePathsNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>GLboolean glIsPathNV(GLuint path);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLboolean> glIsPathNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>GLboolean glIsPointInFillPathNV(GLuint path, GLuint mask, GLfloat x, GLfloat y);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint, GLfloat, GLfloat, GLboolean> glIsPointInFillPathNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>GLboolean glIsPointInStrokePathNV(GLuint path, GLfloat x, GLfloat y);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLfloat, GLfloat, GLboolean> glIsPointInStrokePathNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMatrixFrustumEXT(GLenum mode, GLdouble left, GLdouble right, GLdouble bottom, GLdouble top, GLdouble zNear, GLdouble zFar);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MatrixMode, GLdouble, GLdouble, GLdouble, GLdouble, GLdouble, GLdouble, void> glMatrixFrustumEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMatrixLoad3x2fNV(GLenum matrixMode, GLfloat* m);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, GLfloat*, void> glMatrixLoad3x2fNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMatrixLoad3x3fNV(GLenum matrixMode, GLfloat* m);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, GLfloat*, void> glMatrixLoad3x3fNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMatrixLoaddEXT(GLenum mode, GLdouble* m);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MatrixMode, GLdouble*, void> glMatrixLoaddEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMatrixLoadfEXT(GLenum mode, GLfloat* m);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MatrixMode, GLfloat*, void> glMatrixLoadfEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMatrixLoadIdentityEXT(GLenum mode);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MatrixMode, void> glMatrixLoadIdentityEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMatrixLoadTranspose3x3fNV(GLenum matrixMode, GLfloat* m);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, GLfloat*, void> glMatrixLoadTranspose3x3fNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMatrixLoadTransposedEXT(GLenum mode, GLdouble* m);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MatrixMode, GLdouble*, void> glMatrixLoadTransposedEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMatrixLoadTransposefEXT(GLenum mode, GLfloat* m);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MatrixMode, GLfloat*, void> glMatrixLoadTransposefEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMatrixMult3x2fNV(GLenum matrixMode, GLfloat* m);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, GLfloat*, void> glMatrixMult3x2fNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMatrixMult3x3fNV(GLenum matrixMode, GLfloat* m);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, GLfloat*, void> glMatrixMult3x3fNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMatrixMultdEXT(GLenum mode, GLdouble* m);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MatrixMode, GLdouble*, void> glMatrixMultdEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMatrixMultfEXT(GLenum mode, GLfloat* m);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MatrixMode, GLfloat*, void> glMatrixMultfEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMatrixMultTranspose3x3fNV(GLenum matrixMode, GLfloat* m);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, GLfloat*, void> glMatrixMultTranspose3x3fNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMatrixMultTransposedEXT(GLenum mode, GLdouble* m);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MatrixMode, GLdouble*, void> glMatrixMultTransposedEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMatrixMultTransposefEXT(GLenum mode, GLfloat* m);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MatrixMode, GLfloat*, void> glMatrixMultTransposefEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMatrixOrthoEXT(GLenum mode, GLdouble left, GLdouble right, GLdouble bottom, GLdouble top, GLdouble zNear, GLdouble zFar);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MatrixMode, GLdouble, GLdouble, GLdouble, GLdouble, GLdouble, GLdouble, void> glMatrixOrthoEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMatrixPopEXT(GLenum mode);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MatrixMode, void> glMatrixPopEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMatrixPushEXT(GLenum mode);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MatrixMode, void> glMatrixPushEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMatrixRotatedEXT(GLenum mode, GLdouble angle, GLdouble x, GLdouble y, GLdouble z);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MatrixMode, GLdouble, GLdouble, GLdouble, GLdouble, void> glMatrixRotatedEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMatrixRotatefEXT(GLenum mode, GLfloat angle, GLfloat x, GLfloat y, GLfloat z);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MatrixMode, GLfloat, GLfloat, GLfloat, GLfloat, void> glMatrixRotatefEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMatrixScaledEXT(GLenum mode, GLdouble x, GLdouble y, GLdouble z);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MatrixMode, GLdouble, GLdouble, GLdouble, void> glMatrixScaledEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMatrixScalefEXT(GLenum mode, GLfloat x, GLfloat y, GLfloat z);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MatrixMode, GLfloat, GLfloat, GLfloat, void> glMatrixScalefEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMatrixTranslatedEXT(GLenum mode, GLdouble x, GLdouble y, GLdouble z);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MatrixMode, GLdouble, GLdouble, GLdouble, void> glMatrixTranslatedEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMatrixTranslatefEXT(GLenum mode, GLfloat x, GLfloat y, GLfloat z);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MatrixMode, GLfloat, GLfloat, GLfloat, void> glMatrixTranslatefEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glPathColorGenNV(GLenum color, GLenum genMode, GLenum colorFormat, GLfloat* coeffs);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PathColor, PathGenMode, PathColorFormat, GLfloat*, void> glPathColorGenNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glPathCommandsNV(GLuint path, GLsizei numCommands, GLubyte* commands, GLsizei numCoords, GLenum coordType, void* coords);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLsizei, GLubyte*, GLsizei, PathCoordType, void*, void> glPathCommandsNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glPathCoordsNV(GLuint path, GLsizei numCoords, GLenum coordType, void* coords);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLsizei, PathCoordType, void*, void> glPathCoordsNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glPathCoverDepthFuncNV(GLenum func);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<DepthFunction, void> glPathCoverDepthFuncNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glPathDashArrayNV(GLuint path, GLsizei dashCount, GLfloat* dashArray);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLsizei, GLfloat*, void> glPathDashArrayNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glPathFogGenNV(GLenum genMode);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PathGenMode, void> glPathFogGenNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>GLenum glPathGlyphIndexArrayNV(GLuint firstPathName, GLenum fontTarget, void* fontName, GLbitfield fontStyle, GLuint firstGlyphIndex, GLsizei numGlyphs, GLuint pathParameterTemplate, GLfloat emScale);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLenum, void*, PathFontStyle, GLuint, GLsizei, GLuint, GLfloat, GLenum> glPathGlyphIndexArrayNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>GLenum glPathGlyphIndexRangeNV(GLenum fontTarget, void* fontName, GLbitfield fontStyle, GLuint pathParameterTemplate, GLfloat emScale, GLuint* baseAndCount);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, void*, PathFontStyle, GLuint, GLfloat, GLuint*, GLenum> glPathGlyphIndexRangeNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glPathGlyphRangeNV(GLuint firstPathName, GLenum fontTarget, void* fontName, GLbitfield fontStyle, GLuint firstGlyph, GLsizei numGlyphs, GLenum handleMissingGlyphs, GLuint pathParameterTemplate, GLfloat emScale);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, PathFontTarget, void*, PathFontStyle, GLuint, GLsizei, PathHandleMissingGlyphs, GLuint, GLfloat, void> glPathGlyphRangeNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glPathGlyphsNV(GLuint firstPathName, GLenum fontTarget, void* fontName, GLbitfield fontStyle, GLsizei numGlyphs, GLenum type, void* charcodes, GLenum handleMissingGlyphs, GLuint pathParameterTemplate, GLfloat emScale);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, PathFontTarget, void*, PathFontStyle, GLsizei, PathElementType, void*, PathHandleMissingGlyphs, GLuint, GLfloat, void> glPathGlyphsNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>GLenum glPathMemoryGlyphIndexArrayNV(GLuint firstPathName, GLenum fontTarget, GLsizeiptr fontSize, void* fontData, GLsizei faceIndex, GLuint firstGlyphIndex, GLsizei numGlyphs, GLuint pathParameterTemplate, GLfloat emScale);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLenum, GLsizeiptr, void*, GLsizei, GLuint, GLsizei, GLuint, GLfloat, GLenum> glPathMemoryGlyphIndexArrayNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glPathParameterfNV(GLuint path, GLenum pname, GLfloat value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, PathParameter, GLfloat, void> glPathParameterfNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glPathParameterfvNV(GLuint path, GLenum pname, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, PathParameter, GLfloat*, void> glPathParameterfvNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glPathParameteriNV(GLuint path, GLenum pname, GLint value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, PathParameter, GLint, void> glPathParameteriNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glPathParameterivNV(GLuint path, GLenum pname, GLint* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, PathParameter, GLint*, void> glPathParameterivNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glPathStencilDepthOffsetNV(GLfloat factor, GLfloat units);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLfloat, void> glPathStencilDepthOffsetNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glPathStencilFuncNV(GLenum func, GLint ref, GLuint mask);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<StencilFunction, GLint, GLuint, void> glPathStencilFuncNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glPathStringNV(GLuint path, GLenum format, GLsizei length, void* pathString);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, PathStringFormat, GLsizei, void*, void> glPathStringNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glPathSubCommandsNV(GLuint path, GLsizei commandStart, GLsizei commandsToDelete, GLsizei numCommands, GLubyte* commands, GLsizei numCoords, GLenum coordType, void* coords);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLsizei, GLsizei, GLsizei, GLubyte*, GLsizei, PathCoordType, void*, void> glPathSubCommandsNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glPathSubCoordsNV(GLuint path, GLsizei coordStart, GLsizei numCoords, GLenum coordType, void* coords);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLsizei, GLsizei, PathCoordType, void*, void> glPathSubCoordsNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glPathTexGenNV(GLenum texCoordSet, GLenum genMode, GLint components, GLfloat* coeffs);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PathColor, PathGenMode, GLint, GLfloat*, void> glPathTexGenNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>GLboolean glPointAlongPathNV(GLuint path, GLsizei startSegment, GLsizei numSegments, GLfloat distance, GLfloat* x, GLfloat* y, GLfloat* tangentX, GLfloat* tangentY);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLsizei, GLsizei, GLfloat, GLfloat*, GLfloat*, GLfloat*, GLfloat*, GLboolean> glPointAlongPathNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glProgramPathFragmentInputGenNV(GLuint program, GLint location, GLenum genMode, GLint components, GLfloat* coeffs);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLenum, GLint, GLfloat*, void> glProgramPathFragmentInputGenNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glStencilFillPathInstancedNV(GLsizei numPaths, GLenum pathNameType, void* paths, GLuint pathBase, GLenum fillMode, GLuint mask, GLenum transformType, GLfloat* transformValues);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, PathElementType, void*, GLuint, PathFillMode, GLuint, PathTransformType, GLfloat*, void> glStencilFillPathInstancedNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glStencilFillPathNV(GLuint path, GLenum fillMode, GLuint mask);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, PathFillMode, GLuint, void> glStencilFillPathNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glStencilStrokePathInstancedNV(GLsizei numPaths, GLenum pathNameType, void* paths, GLuint pathBase, GLint reference, GLuint mask, GLenum transformType, GLfloat* transformValues);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, PathElementType, void*, GLuint, GLint, GLuint, PathTransformType, GLfloat*, void> glStencilStrokePathInstancedNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glStencilStrokePathNV(GLuint path, GLint reference, GLuint mask);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLint, GLuint, void> glStencilStrokePathNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glStencilThenCoverFillPathInstancedNV(GLsizei numPaths, GLenum pathNameType, void* paths, GLuint pathBase, GLenum fillMode, GLuint mask, GLenum coverMode, GLenum transformType, GLfloat* transformValues);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLenum, void*, GLuint, GLenum, GLuint, GLenum, GLenum, GLfloat*, void> glStencilThenCoverFillPathInstancedNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glStencilThenCoverFillPathNV(GLuint path, GLenum fillMode, GLuint mask, GLenum coverMode);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLenum, GLuint, GLenum, void> glStencilThenCoverFillPathNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glStencilThenCoverStrokePathInstancedNV(GLsizei numPaths, GLenum pathNameType, void* paths, GLuint pathBase, GLint reference, GLuint mask, GLenum coverMode, GLenum transformType, GLfloat* transformValues);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLenum, void*, GLuint, GLint, GLuint, GLenum, GLenum, GLfloat*, void> glStencilThenCoverStrokePathInstancedNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glStencilThenCoverStrokePathNV(GLuint path, GLint reference, GLuint mask, GLenum coverMode);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLint, GLuint, GLenum, void> glStencilThenCoverStrokePathNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glTransformPathNV(GLuint resultPath, GLuint srcPath, GLenum transformType, GLfloat* transformValues);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint, PathTransformType, GLfloat*, void> glTransformPathNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glWeightPathsNV(GLuint resultPath, GLsizei numPaths, GLuint* paths, GLfloat* weights);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLsizei, GLuint*, GLfloat*, void> glWeightPathsNV;
#endif
    }
}
#endif