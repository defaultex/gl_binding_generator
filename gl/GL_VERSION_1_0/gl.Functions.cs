#if (GL_VERSION_1_0 && GL_API)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glAccum(GLenum op, GLfloat value)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<AccumOp, GLfloat, void> glAccum;

        /// <summary>void glAlphaFunc(GLenum func, GLfloat ref)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<AlphaFunction, GLfloat, void> glAlphaFunc;

        /// <summary>void glBegin(GLenum mode)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, void> glBegin;

        /// <summary>void glBitmap(GLsizei width, GLsizei height, GLfloat xorig, GLfloat yorig, GLfloat xmove, GLfloat ymove, const GLubyte* bitmap)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLsizei, GLfloat, GLfloat, GLfloat, GLfloat, GLubyte*, void> glBitmap;

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)

        /// <summary>void glBlendFunc(GLenum sfactor, GLenum dfactor)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BlendingFactor, BlendingFactor, void> glBlendFunc;

#endif

        /// <summary>void glCallList(GLuint list)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, void> glCallList;

        /// <summary>void glCallLists(GLsizei n, GLenum type, const void* lists)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, ListNameType, void*, void> glCallLists;

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)

        /// <summary>void glClear(GLbitfield mask)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ClearBufferMask, void> glClear;

#endif

        /// <summary>void glClearAccum(GLfloat red, GLfloat green, GLfloat blue, GLfloat alpha)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLfloat, GLfloat, GLfloat, void> glClearAccum;

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)

        /// <summary>void glClearColor(GLfloat red, GLfloat green, GLfloat blue, GLfloat alpha)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLfloat, GLfloat, GLfloat, void> glClearColor;

#endif

        /// <summary>void glClearDepth(GLdouble depth)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLdouble, void> glClearDepth;

        /// <summary>void glClearIndex(GLfloat c)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, void> glClearIndex;

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)

        /// <summary>void glClearStencil(GLint s)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, void> glClearStencil;

#endif

        /// <summary>void glClipPlane(GLenum plane, const GLdouble* equation)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ClipPlaneName, GLdouble*, void> glClipPlane;

        /// <summary>void glColor3b(GLbyte red, GLbyte green, GLbyte blue)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLbyte, GLbyte, GLbyte, void> glColor3b;

        /// <summary>void glColor3bv(const GLbyte* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLbyte*, void> glColor3bv;

        /// <summary>void glColor3d(GLdouble red, GLdouble green, GLdouble blue)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLdouble, GLdouble, GLdouble, void> glColor3d;

        /// <summary>void glColor3dv(const GLdouble* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLdouble*, void> glColor3dv;

        /// <summary>void glColor3f(GLfloat red, GLfloat green, GLfloat blue)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLfloat, GLfloat, void> glColor3f;

        /// <summary>void glColor3fv(const GLfloat* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat*, void> glColor3fv;

        /// <summary>void glColor3i(GLint red, GLint green, GLint blue)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLint, GLint, void> glColor3i;

        /// <summary>void glColor3iv(const GLint* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint*, void> glColor3iv;

        /// <summary>void glColor3s(GLshort red, GLshort green, GLshort blue)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLshort, GLshort, GLshort, void> glColor3s;

        /// <summary>void glColor3sv(const GLshort* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLshort*, void> glColor3sv;

        /// <summary>void glColor3ub(GLubyte red, GLubyte green, GLubyte blue)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLubyte, GLubyte, GLubyte, void> glColor3ub;

        /// <summary>void glColor3ubv(const GLubyte* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLubyte*, void> glColor3ubv;

        /// <summary>void glColor3ui(GLuint red, GLuint green, GLuint blue)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint, GLuint, void> glColor3ui;

        /// <summary>void glColor3uiv(const GLuint* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint*, void> glColor3uiv;

        /// <summary>void glColor3us(GLushort red, GLushort green, GLushort blue)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLushort, GLushort, GLushort, void> glColor3us;

        /// <summary>void glColor3usv(const GLushort* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLushort*, void> glColor3usv;

        /// <summary>void glColor4b(GLbyte red, GLbyte green, GLbyte blue, GLbyte alpha)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLbyte, GLbyte, GLbyte, GLbyte, void> glColor4b;

        /// <summary>void glColor4bv(const GLbyte* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLbyte*, void> glColor4bv;

        /// <summary>void glColor4d(GLdouble red, GLdouble green, GLdouble blue, GLdouble alpha)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLdouble, GLdouble, GLdouble, GLdouble, void> glColor4d;

        /// <summary>void glColor4dv(const GLdouble* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLdouble*, void> glColor4dv;

        /// <summary>void glColor4f(GLfloat red, GLfloat green, GLfloat blue, GLfloat alpha)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLfloat, GLfloat, GLfloat, void> glColor4f;

        /// <summary>void glColor4fv(const GLfloat* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat*, void> glColor4fv;

        /// <summary>void glColor4i(GLint red, GLint green, GLint blue, GLint alpha)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLint, GLint, GLint, void> glColor4i;

        /// <summary>void glColor4iv(const GLint* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint*, void> glColor4iv;

        /// <summary>void glColor4s(GLshort red, GLshort green, GLshort blue, GLshort alpha)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLshort, GLshort, GLshort, GLshort, void> glColor4s;

        /// <summary>void glColor4sv(const GLshort* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLshort*, void> glColor4sv;

        /// <summary>void glColor4ub(GLubyte red, GLubyte green, GLubyte blue, GLubyte alpha)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLubyte, GLubyte, GLubyte, GLubyte, void> glColor4ub;

        /// <summary>void glColor4ubv(const GLubyte* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLubyte*, void> glColor4ubv;

        /// <summary>void glColor4ui(GLuint red, GLuint green, GLuint blue, GLuint alpha)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint, GLuint, GLuint, void> glColor4ui;

        /// <summary>void glColor4uiv(const GLuint* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint*, void> glColor4uiv;

        /// <summary>void glColor4us(GLushort red, GLushort green, GLushort blue, GLushort alpha)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLushort, GLushort, GLushort, GLushort, void> glColor4us;

        /// <summary>void glColor4usv(const GLushort* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLushort*, void> glColor4usv;

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)

        /// <summary>void glColorMask(GLboolean red, GLboolean green, GLboolean blue, GLboolean alpha)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLboolean, GLboolean, GLboolean, GLboolean, void> glColorMask;

#endif

        /// <summary>void glColorMaterial(GLenum face, GLenum mode)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MaterialFace, ColorMaterialParameter, void> glColorMaterial;

        /// <summary>void glCopyPixels(GLint x, GLint y, GLsizei width, GLsizei height, GLenum type)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLint, GLsizei, GLsizei, PixelCopyType, void> glCopyPixels;

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)

        /// <summary>void glCullFace(GLenum mode)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<CullFaceMode, void> glCullFace;

#endif

        /// <summary>void glDeleteLists(GLuint list, GLsizei range)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLdisplaylist, GLsizei, void> glDeleteLists;

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)

        /// <summary>void glDepthFunc(GLenum func)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<DepthFunction, void> glDepthFunc;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)

        /// <summary>void glDepthMask(GLboolean flag)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLboolean, void> glDepthMask;

#endif

        /// <summary>void glDepthRange(GLdouble n, GLdouble f)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLdouble, GLdouble, void> glDepthRange;

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)

        /// <summary>void glDisable(GLenum cap)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<EnableCap, void> glDisable;

#endif

        /// <summary>void glDrawBuffer(GLenum buf)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<DrawBufferMode, void> glDrawBuffer;

        /// <summary>void glDrawPixels(GLsizei width, GLsizei height, GLenum format, GLenum type, const void* pixels)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLsizei, PixelFormat, PixelType, void*, void> glDrawPixels;

        /// <summary>void glEdgeFlag(GLboolean flag)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLboolean, void> glEdgeFlag;

        /// <summary>void glEdgeFlagv(const GLboolean* flag)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLboolean*, void> glEdgeFlagv;

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)

        /// <summary>void glEnable(GLenum cap)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<EnableCap, void> glEnable;

#endif

        /// <summary>void glEnd()</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void> glEnd;

        /// <summary>void glEndList()</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void> glEndList;

        /// <summary>void glEvalCoord1d(GLdouble u)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLdouble, void> glEvalCoord1d;

        /// <summary>void glEvalCoord1dv(const GLdouble* u)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLdouble*, void> glEvalCoord1dv;

        /// <summary>void glEvalCoord1f(GLfloat u)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, void> glEvalCoord1f;

        /// <summary>void glEvalCoord1fv(const GLfloat* u)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat*, void> glEvalCoord1fv;

        /// <summary>void glEvalCoord2d(GLdouble u, GLdouble v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLdouble, GLdouble, void> glEvalCoord2d;

        /// <summary>void glEvalCoord2dv(const GLdouble* u)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLdouble*, void> glEvalCoord2dv;

        /// <summary>void glEvalCoord2f(GLfloat u, GLfloat v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLfloat, void> glEvalCoord2f;

        /// <summary>void glEvalCoord2fv(const GLfloat* u)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat*, void> glEvalCoord2fv;

        /// <summary>void glEvalMesh1(GLenum mode, GLint i1, GLint i2)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MeshMode1, GLint, GLint, void> glEvalMesh1;

        /// <summary>void glEvalMesh2(GLenum mode, GLint i1, GLint i2, GLint j1, GLint j2)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MeshMode2, GLint, GLint, GLint, GLint, void> glEvalMesh2;

        /// <summary>void glEvalPoint1(GLint i)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, void> glEvalPoint1;

        /// <summary>void glEvalPoint2(GLint i, GLint j)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLint, void> glEvalPoint2;

        /// <summary>void glFeedbackBuffer(GLsizei size, GLenum type, GLfloat* buffer)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, FeedbackType, GLfloat*, void> glFeedbackBuffer;

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)

        /// <summary>void glFinish()</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void> glFinish;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)

        /// <summary>void glFlush()</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void> glFlush;

#endif

        /// <summary>void glFogf(GLenum pname, GLfloat param)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FogParameter, GLfloat, void> glFogf;

        /// <summary>void glFogfv(GLenum pname, const GLfloat* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FogParameter, GLfloat*, void> glFogfv;

        /// <summary>void glFogi(GLenum pname, GLint param)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FogParameter, GLint, void> glFogi;

        /// <summary>void glFogiv(GLenum pname, const GLint* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FogParameter, GLint*, void> glFogiv;

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)

        /// <summary>void glFrontFace(GLenum mode)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FrontFaceDirection, void> glFrontFace;

#endif

        /// <summary>void glFrustum(GLdouble left, GLdouble right, GLdouble bottom, GLdouble top, GLdouble zNear, GLdouble zFar)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLdouble, GLdouble, GLdouble, GLdouble, GLdouble, GLdouble, void> glFrustum;

        /// <summary>GLuint glGenLists(GLsizei range)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLuint> glGenLists;

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)

        /// <summary>void glGetBooleanv(GLenum pname, GLboolean* data)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GetPName, GLboolean*, void> glGetBooleanv;

#endif

        /// <summary>void glGetClipPlane(GLenum plane, GLdouble* equation)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ClipPlaneName, GLdouble*, void> glGetClipPlane;

        /// <summary>void glGetDoublev(GLenum pname, GLdouble* data)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GetPName, GLdouble*, void> glGetDoublev;

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)

        /// <summary>GLenum glGetError()</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum> glGetError;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)

        /// <summary>void glGetFloatv(GLenum pname, GLfloat* data)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GetPName, GLfloat*, void> glGetFloatv;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)

        /// <summary>void glGetIntegerv(GLenum pname, GLint* data)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GetPName, GLint*, void> glGetIntegerv;

#endif

        /// <summary>void glGetLightfv(GLenum light, GLenum pname, GLfloat* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<LightName, LightParameter, GLfloat*, void> glGetLightfv;

        /// <summary>void glGetLightiv(GLenum light, GLenum pname, GLint* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<LightName, LightParameter, GLint*, void> glGetLightiv;

        /// <summary>void glGetMapdv(GLenum target, GLenum query, GLdouble* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MapTarget, GetMapQuery, GLdouble*, void> glGetMapdv;

        /// <summary>void glGetMapfv(GLenum target, GLenum query, GLfloat* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MapTarget, GetMapQuery, GLfloat*, void> glGetMapfv;

        /// <summary>void glGetMapiv(GLenum target, GLenum query, GLint* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MapTarget, GetMapQuery, GLint*, void> glGetMapiv;

        /// <summary>void glGetMaterialfv(GLenum face, GLenum pname, GLfloat* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MaterialFace, MaterialParameter, GLfloat*, void> glGetMaterialfv;

        /// <summary>void glGetMaterialiv(GLenum face, GLenum pname, GLint* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MaterialFace, MaterialParameter, GLint*, void> glGetMaterialiv;

        /// <summary>void glGetPixelMapfv(GLenum map, GLfloat* values)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PixelMap, GLfloat*, void> glGetPixelMapfv;

        /// <summary>void glGetPixelMapuiv(GLenum map, GLuint* values)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PixelMap, GLuint*, void> glGetPixelMapuiv;

        /// <summary>void glGetPixelMapusv(GLenum map, GLushort* values)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PixelMap, GLushort*, void> glGetPixelMapusv;

        /// <summary>void glGetPolygonStipple(GLubyte* mask)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLubyte*, void> glGetPolygonStipple;

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)

        /// <summary>GLubyte* glGetString(GLenum name)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<StringName, GLubyte*> glGetString;

#endif

        /// <summary>void glGetTexEnvfv(GLenum target, GLenum pname, GLfloat* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureEnvTarget, TextureEnvParameter, GLfloat*, void> glGetTexEnvfv;

        /// <summary>void glGetTexEnviv(GLenum target, GLenum pname, GLint* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureEnvTarget, TextureEnvParameter, GLint*, void> glGetTexEnviv;

        /// <summary>void glGetTexGendv(GLenum coord, GLenum pname, GLdouble* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureCoordName, TextureGenParameter, GLdouble*, void> glGetTexGendv;

        /// <summary>void glGetTexGenfv(GLenum coord, GLenum pname, GLfloat* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureCoordName, TextureGenParameter, GLfloat*, void> glGetTexGenfv;

        /// <summary>void glGetTexGeniv(GLenum coord, GLenum pname, GLint* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureCoordName, TextureGenParameter, GLint*, void> glGetTexGeniv;

        /// <summary>void glGetTexImage(GLenum target, GLint level, GLenum format, GLenum type, void* pixels)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLint, PixelFormat, PixelType, void*, void> glGetTexImage;

#if !GL_ES_VERSION_3_1

        /// <summary>void glGetTexLevelParameterfv(GLenum target, GLint level, GLenum pname, GLfloat* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLint, GetTextureParameter, GLfloat*, void> glGetTexLevelParameterfv;

#endif

#if !GL_ES_VERSION_3_1

        /// <summary>void glGetTexLevelParameteriv(GLenum target, GLint level, GLenum pname, GLint* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLint, GetTextureParameter, GLint*, void> glGetTexLevelParameteriv;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)

        /// <summary>void glGetTexParameterfv(GLenum target, GLenum pname, GLfloat* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GetTextureParameter, GLfloat*, void> glGetTexParameterfv;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)

        /// <summary>void glGetTexParameteriv(GLenum target, GLenum pname, GLint* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GetTextureParameter, GLint*, void> glGetTexParameteriv;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)

        /// <summary>void glHint(GLenum target, GLenum mode)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<HintTarget, HintMode, void> glHint;

#endif

        /// <summary>void glIndexMask(GLuint mask)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, void> glIndexMask;

        /// <summary>void glIndexd(GLdouble c)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLdouble, void> glIndexd;

        /// <summary>void glIndexdv(const GLdouble* c)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLdouble*, void> glIndexdv;

        /// <summary>void glIndexf(GLfloat c)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, void> glIndexf;

        /// <summary>void glIndexfv(const GLfloat* c)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat*, void> glIndexfv;

        /// <summary>void glIndexi(GLint c)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, void> glIndexi;

        /// <summary>void glIndexiv(const GLint* c)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint*, void> glIndexiv;

        /// <summary>void glIndexs(GLshort c)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLshort, void> glIndexs;

        /// <summary>void glIndexsv(const GLshort* c)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLshort*, void> glIndexsv;

        /// <summary>void glInitNames()</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void> glInitNames;

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)

        /// <summary>GLboolean glIsEnabled(GLenum cap)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<EnableCap, GLboolean> glIsEnabled;

#endif

        /// <summary>GLboolean glIsList(GLuint list)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLdisplaylist, GLboolean> glIsList;

        /// <summary>void glLightModelf(GLenum pname, GLfloat param)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<LightModelParameter, GLfloat, void> glLightModelf;

        /// <summary>void glLightModelfv(GLenum pname, const GLfloat* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<LightModelParameter, GLfloat*, void> glLightModelfv;

        /// <summary>void glLightModeli(GLenum pname, GLint param)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<LightModelParameter, GLint, void> glLightModeli;

        /// <summary>void glLightModeliv(GLenum pname, const GLint* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<LightModelParameter, GLint*, void> glLightModeliv;

        /// <summary>void glLightf(GLenum light, GLenum pname, GLfloat param)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<LightName, LightParameter, GLfloat, void> glLightf;

        /// <summary>void glLightfv(GLenum light, GLenum pname, const GLfloat* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<LightName, LightParameter, GLfloat*, void> glLightfv;

        /// <summary>void glLighti(GLenum light, GLenum pname, GLint param)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<LightName, LightParameter, GLint, void> glLighti;

        /// <summary>void glLightiv(GLenum light, GLenum pname, const GLint* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<LightName, LightParameter, GLint*, void> glLightiv;

        /// <summary>void glLineStipple(GLint factor, GLushort pattern)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLushort, void> glLineStipple;

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)

        /// <summary>void glLineWidth(GLfloat width)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, void> glLineWidth;

#endif

        /// <summary>void glListBase(GLuint base)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, void> glListBase;

        /// <summary>void glLoadIdentity()</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void> glLoadIdentity;

        /// <summary>void glLoadMatrixd(const GLdouble* m)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLdouble*, void> glLoadMatrixd;

        /// <summary>void glLoadMatrixf(const GLfloat* m)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat*, void> glLoadMatrixf;

        /// <summary>void glLoadName(GLuint name)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, void> glLoadName;

        /// <summary>void glLogicOp(GLenum opcode)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<LogicOp, void> glLogicOp;

        /// <summary>void glMap1d(GLenum target, GLdouble u1, GLdouble u2, GLint stride, GLint order, const GLdouble* points)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MapTarget, GLdouble, GLdouble, GLint, GLint, GLdouble*, void> glMap1d;

        /// <summary>void glMap1f(GLenum target, GLfloat u1, GLfloat u2, GLint stride, GLint order, const GLfloat* points)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MapTarget, GLfloat, GLfloat, GLint, GLint, GLfloat*, void> glMap1f;

        /// <summary>void glMap2d(GLenum target, GLdouble u1, GLdouble u2, GLint ustride, GLint uorder, GLdouble v1, GLdouble v2, GLint vstride, GLint vorder, const GLdouble* points)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MapTarget, GLdouble, GLdouble, GLint, GLint, GLdouble, GLdouble, GLint, GLint, GLdouble*, void> glMap2d;

        /// <summary>void glMap2f(GLenum target, GLfloat u1, GLfloat u2, GLint ustride, GLint uorder, GLfloat v1, GLfloat v2, GLint vstride, GLint vorder, const GLfloat* points)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MapTarget, GLfloat, GLfloat, GLint, GLint, GLfloat, GLfloat, GLint, GLint, GLfloat*, void> glMap2f;

        /// <summary>void glMapGrid1d(GLint un, GLdouble u1, GLdouble u2)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLdouble, GLdouble, void> glMapGrid1d;

        /// <summary>void glMapGrid1f(GLint un, GLfloat u1, GLfloat u2)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLfloat, GLfloat, void> glMapGrid1f;

        /// <summary>void glMapGrid2d(GLint un, GLdouble u1, GLdouble u2, GLint vn, GLdouble v1, GLdouble v2)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLdouble, GLdouble, GLint, GLdouble, GLdouble, void> glMapGrid2d;

        /// <summary>void glMapGrid2f(GLint un, GLfloat u1, GLfloat u2, GLint vn, GLfloat v1, GLfloat v2)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLfloat, GLfloat, GLint, GLfloat, GLfloat, void> glMapGrid2f;

        /// <summary>void glMaterialf(GLenum face, GLenum pname, GLfloat param)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MaterialFace, MaterialParameter, GLfloat, void> glMaterialf;

        /// <summary>void glMaterialfv(GLenum face, GLenum pname, const GLfloat* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MaterialFace, MaterialParameter, GLfloat*, void> glMaterialfv;

        /// <summary>void glMateriali(GLenum face, GLenum pname, GLint param)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MaterialFace, MaterialParameter, GLint, void> glMateriali;

        /// <summary>void glMaterialiv(GLenum face, GLenum pname, const GLint* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MaterialFace, MaterialParameter, GLint*, void> glMaterialiv;

        /// <summary>void glMatrixMode(GLenum mode)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MatrixMode, void> glMatrixMode;

        /// <summary>void glMultMatrixd(const GLdouble* m)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLdouble*, void> glMultMatrixd;

        /// <summary>void glMultMatrixf(const GLfloat* m)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat*, void> glMultMatrixf;

        /// <summary>void glNewList(GLuint list, GLenum mode)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, ListMode, void> glNewList;

        /// <summary>void glNormal3b(GLbyte nx, GLbyte ny, GLbyte nz)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLbyte, GLbyte, GLbyte, void> glNormal3b;

        /// <summary>void glNormal3bv(const GLbyte* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLbyte*, void> glNormal3bv;

        /// <summary>void glNormal3d(GLdouble nx, GLdouble ny, GLdouble nz)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLdouble, GLdouble, GLdouble, void> glNormal3d;

        /// <summary>void glNormal3dv(const GLdouble* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLdouble*, void> glNormal3dv;

        /// <summary>void glNormal3f(GLfloat nx, GLfloat ny, GLfloat nz)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLfloat, GLfloat, void> glNormal3f;

        /// <summary>void glNormal3fv(const GLfloat* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat*, void> glNormal3fv;

        /// <summary>void glNormal3i(GLint nx, GLint ny, GLint nz)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLint, GLint, void> glNormal3i;

        /// <summary>void glNormal3iv(const GLint* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint*, void> glNormal3iv;

        /// <summary>void glNormal3s(GLshort nx, GLshort ny, GLshort nz)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLshort, GLshort, GLshort, void> glNormal3s;

        /// <summary>void glNormal3sv(const GLshort* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLshort*, void> glNormal3sv;

        /// <summary>void glOrtho(GLdouble left, GLdouble right, GLdouble bottom, GLdouble top, GLdouble zNear, GLdouble zFar)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLdouble, GLdouble, GLdouble, GLdouble, GLdouble, GLdouble, void> glOrtho;

        /// <summary>void glPassThrough(GLfloat token)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, void> glPassThrough;

        /// <summary>void glPixelMapfv(GLenum map, GLsizei mapsize, const GLfloat* values)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PixelMap, GLsizei, GLfloat*, void> glPixelMapfv;

        /// <summary>void glPixelMapuiv(GLenum map, GLsizei mapsize, const GLuint* values)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PixelMap, GLsizei, GLuint*, void> glPixelMapuiv;

        /// <summary>void glPixelMapusv(GLenum map, GLsizei mapsize, const GLushort* values)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PixelMap, GLsizei, GLushort*, void> glPixelMapusv;

        /// <summary>void glPixelStoref(GLenum pname, GLfloat param)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PixelStoreParameter, GLfloat, void> glPixelStoref;

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)

        /// <summary>void glPixelStorei(GLenum pname, GLint param)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PixelStoreParameter, GLint, void> glPixelStorei;

#endif

        /// <summary>void glPixelTransferf(GLenum pname, GLfloat param)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PixelTransferParameter, GLfloat, void> glPixelTransferf;

        /// <summary>void glPixelTransferi(GLenum pname, GLint param)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PixelTransferParameter, GLint, void> glPixelTransferi;

        /// <summary>void glPixelZoom(GLfloat xfactor, GLfloat yfactor)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLfloat, void> glPixelZoom;

        /// <summary>void glPointSize(GLfloat size)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, void> glPointSize;

        /// <summary>void glPolygonMode(GLenum face, GLenum mode)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MaterialFace, PolygonMode, void> glPolygonMode;

        /// <summary>void glPolygonStipple(const GLubyte* mask)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLubyte*, void> glPolygonStipple;

        /// <summary>void glPopAttrib()</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void> glPopAttrib;

        /// <summary>void glPopMatrix()</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void> glPopMatrix;

        /// <summary>void glPopName()</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void> glPopName;

        /// <summary>void glPushAttrib(GLbitfield mask)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<AttribMask, void> glPushAttrib;

        /// <summary>void glPushMatrix()</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void> glPushMatrix;

        /// <summary>void glPushName(GLuint name)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, void> glPushName;

        /// <summary>void glRasterPos2d(GLdouble x, GLdouble y)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLdouble, GLdouble, void> glRasterPos2d;

        /// <summary>void glRasterPos2dv(const GLdouble* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLdouble*, void> glRasterPos2dv;

        /// <summary>void glRasterPos2f(GLfloat x, GLfloat y)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLfloat, void> glRasterPos2f;

        /// <summary>void glRasterPos2fv(const GLfloat* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat*, void> glRasterPos2fv;

        /// <summary>void glRasterPos2i(GLint x, GLint y)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLint, void> glRasterPos2i;

        /// <summary>void glRasterPos2iv(const GLint* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint*, void> glRasterPos2iv;

        /// <summary>void glRasterPos2s(GLshort x, GLshort y)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLshort, GLshort, void> glRasterPos2s;

        /// <summary>void glRasterPos2sv(const GLshort* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLshort*, void> glRasterPos2sv;

        /// <summary>void glRasterPos3d(GLdouble x, GLdouble y, GLdouble z)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLdouble, GLdouble, GLdouble, void> glRasterPos3d;

        /// <summary>void glRasterPos3dv(const GLdouble* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLdouble*, void> glRasterPos3dv;

        /// <summary>void glRasterPos3f(GLfloat x, GLfloat y, GLfloat z)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLfloat, GLfloat, void> glRasterPos3f;

        /// <summary>void glRasterPos3fv(const GLfloat* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat*, void> glRasterPos3fv;

        /// <summary>void glRasterPos3i(GLint x, GLint y, GLint z)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLint, GLint, void> glRasterPos3i;

        /// <summary>void glRasterPos3iv(const GLint* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint*, void> glRasterPos3iv;

        /// <summary>void glRasterPos3s(GLshort x, GLshort y, GLshort z)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLshort, GLshort, GLshort, void> glRasterPos3s;

        /// <summary>void glRasterPos3sv(const GLshort* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLshort*, void> glRasterPos3sv;

        /// <summary>void glRasterPos4d(GLdouble x, GLdouble y, GLdouble z, GLdouble w)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLdouble, GLdouble, GLdouble, GLdouble, void> glRasterPos4d;

        /// <summary>void glRasterPos4dv(const GLdouble* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLdouble*, void> glRasterPos4dv;

        /// <summary>void glRasterPos4f(GLfloat x, GLfloat y, GLfloat z, GLfloat w)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLfloat, GLfloat, GLfloat, void> glRasterPos4f;

        /// <summary>void glRasterPos4fv(const GLfloat* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat*, void> glRasterPos4fv;

        /// <summary>void glRasterPos4i(GLint x, GLint y, GLint z, GLint w)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLint, GLint, GLint, void> glRasterPos4i;

        /// <summary>void glRasterPos4iv(const GLint* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint*, void> glRasterPos4iv;

        /// <summary>void glRasterPos4s(GLshort x, GLshort y, GLshort z, GLshort w)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLshort, GLshort, GLshort, GLshort, void> glRasterPos4s;

        /// <summary>void glRasterPos4sv(const GLshort* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLshort*, void> glRasterPos4sv;

#if !GL_ES_VERSION_3_0

        /// <summary>void glReadBuffer(GLenum src)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ReadBufferMode, void> glReadBuffer;

#endif

#if !GL_ES_VERSION_2_0

        /// <summary>void glReadPixels(GLint x, GLint y, GLsizei width, GLsizei height, GLenum format, GLenum type, void* pixels)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLint, GLsizei, GLsizei, PixelFormat, PixelType, void*, void> glReadPixels;

#endif

        /// <summary>void glRectd(GLdouble x1, GLdouble y1, GLdouble x2, GLdouble y2)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLdouble, GLdouble, GLdouble, GLdouble, void> glRectd;

        /// <summary>void glRectdv(const GLdouble* v1, const GLdouble* v2)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLdouble*, GLdouble*, void> glRectdv;

        /// <summary>void glRectf(GLfloat x1, GLfloat y1, GLfloat x2, GLfloat y2)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLfloat, GLfloat, GLfloat, void> glRectf;

        /// <summary>void glRectfv(const GLfloat* v1, const GLfloat* v2)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat*, GLfloat*, void> glRectfv;

        /// <summary>void glRecti(GLint x1, GLint y1, GLint x2, GLint y2)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLint, GLint, GLint, void> glRecti;

        /// <summary>void glRectiv(const GLint* v1, const GLint* v2)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint*, GLint*, void> glRectiv;

        /// <summary>void glRects(GLshort x1, GLshort y1, GLshort x2, GLshort y2)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLshort, GLshort, GLshort, GLshort, void> glRects;

        /// <summary>void glRectsv(const GLshort* v1, const GLshort* v2)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLshort*, GLshort*, void> glRectsv;

        /// <summary>GLint glRenderMode(GLenum mode)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<RenderingMode, GLint> glRenderMode;

        /// <summary>void glRotated(GLdouble angle, GLdouble x, GLdouble y, GLdouble z)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLdouble, GLdouble, GLdouble, GLdouble, void> glRotated;

        /// <summary>void glRotatef(GLfloat angle, GLfloat x, GLfloat y, GLfloat z)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLfloat, GLfloat, GLfloat, void> glRotatef;

        /// <summary>void glScaled(GLdouble x, GLdouble y, GLdouble z)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLdouble, GLdouble, GLdouble, void> glScaled;

        /// <summary>void glScalef(GLfloat x, GLfloat y, GLfloat z)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLfloat, GLfloat, void> glScalef;

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)

        /// <summary>void glScissor(GLint x, GLint y, GLsizei width, GLsizei height)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLint, GLsizei, GLsizei, void> glScissor;

#endif

        /// <summary>void glSelectBuffer(GLsizei size, GLuint* buffer)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLuint*, void> glSelectBuffer;

        /// <summary>void glShadeModel(GLenum mode)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ShadingModel, void> glShadeModel;

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)

        /// <summary>void glStencilFunc(GLenum func, GLint ref, GLuint mask)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<StencilFunction, GLint, GLuint, void> glStencilFunc;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)

        /// <summary>void glStencilMask(GLuint mask)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, void> glStencilMask;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)

        /// <summary>void glStencilOp(GLenum fail, GLenum zfail, GLenum zpass)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<StencilOp, StencilOp, StencilOp, void> glStencilOp;

#endif

        /// <summary>void glTexCoord1d(GLdouble s)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLdouble, void> glTexCoord1d;

        /// <summary>void glTexCoord1dv(const GLdouble* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLdouble*, void> glTexCoord1dv;

        /// <summary>void glTexCoord1f(GLfloat s)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, void> glTexCoord1f;

        /// <summary>void glTexCoord1fv(const GLfloat* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat*, void> glTexCoord1fv;

        /// <summary>void glTexCoord1i(GLint s)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, void> glTexCoord1i;

        /// <summary>void glTexCoord1iv(const GLint* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint*, void> glTexCoord1iv;

        /// <summary>void glTexCoord1s(GLshort s)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLshort, void> glTexCoord1s;

        /// <summary>void glTexCoord1sv(const GLshort* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLshort*, void> glTexCoord1sv;

        /// <summary>void glTexCoord2d(GLdouble s, GLdouble t)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLdouble, GLdouble, void> glTexCoord2d;

        /// <summary>void glTexCoord2dv(const GLdouble* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLdouble*, void> glTexCoord2dv;

        /// <summary>void glTexCoord2f(GLfloat s, GLfloat t)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLfloat, void> glTexCoord2f;

        /// <summary>void glTexCoord2fv(const GLfloat* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat*, void> glTexCoord2fv;

        /// <summary>void glTexCoord2i(GLint s, GLint t)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLint, void> glTexCoord2i;

        /// <summary>void glTexCoord2iv(const GLint* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint*, void> glTexCoord2iv;

        /// <summary>void glTexCoord2s(GLshort s, GLshort t)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLshort, GLshort, void> glTexCoord2s;

        /// <summary>void glTexCoord2sv(const GLshort* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLshort*, void> glTexCoord2sv;

        /// <summary>void glTexCoord3d(GLdouble s, GLdouble t, GLdouble r)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLdouble, GLdouble, GLdouble, void> glTexCoord3d;

        /// <summary>void glTexCoord3dv(const GLdouble* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLdouble*, void> glTexCoord3dv;

        /// <summary>void glTexCoord3f(GLfloat s, GLfloat t, GLfloat r)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLfloat, GLfloat, void> glTexCoord3f;

        /// <summary>void glTexCoord3fv(const GLfloat* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat*, void> glTexCoord3fv;

        /// <summary>void glTexCoord3i(GLint s, GLint t, GLint r)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLint, GLint, void> glTexCoord3i;

        /// <summary>void glTexCoord3iv(const GLint* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint*, void> glTexCoord3iv;

        /// <summary>void glTexCoord3s(GLshort s, GLshort t, GLshort r)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLshort, GLshort, GLshort, void> glTexCoord3s;

        /// <summary>void glTexCoord3sv(const GLshort* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLshort*, void> glTexCoord3sv;

        /// <summary>void glTexCoord4d(GLdouble s, GLdouble t, GLdouble r, GLdouble q)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLdouble, GLdouble, GLdouble, GLdouble, void> glTexCoord4d;

        /// <summary>void glTexCoord4dv(const GLdouble* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLdouble*, void> glTexCoord4dv;

        /// <summary>void glTexCoord4f(GLfloat s, GLfloat t, GLfloat r, GLfloat q)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLfloat, GLfloat, GLfloat, void> glTexCoord4f;

        /// <summary>void glTexCoord4fv(const GLfloat* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat*, void> glTexCoord4fv;

        /// <summary>void glTexCoord4i(GLint s, GLint t, GLint r, GLint q)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLint, GLint, GLint, void> glTexCoord4i;

        /// <summary>void glTexCoord4iv(const GLint* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint*, void> glTexCoord4iv;

        /// <summary>void glTexCoord4s(GLshort s, GLshort t, GLshort r, GLshort q)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLshort, GLshort, GLshort, GLshort, void> glTexCoord4s;

        /// <summary>void glTexCoord4sv(const GLshort* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLshort*, void> glTexCoord4sv;

        /// <summary>void glTexEnvf(GLenum target, GLenum pname, GLfloat param)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureEnvTarget, TextureEnvParameter, GLfloat, void> glTexEnvf;

        /// <summary>void glTexEnvfv(GLenum target, GLenum pname, const GLfloat* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureEnvTarget, TextureEnvParameter, GLfloat*, void> glTexEnvfv;

        /// <summary>void glTexEnvi(GLenum target, GLenum pname, GLint param)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureEnvTarget, TextureEnvParameter, GLint, void> glTexEnvi;

        /// <summary>void glTexEnviv(GLenum target, GLenum pname, const GLint* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureEnvTarget, TextureEnvParameter, GLint*, void> glTexEnviv;

        /// <summary>void glTexGend(GLenum coord, GLenum pname, GLdouble param)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureCoordName, TextureGenParameter, GLdouble, void> glTexGend;

        /// <summary>void glTexGendv(GLenum coord, GLenum pname, const GLdouble* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureCoordName, TextureGenParameter, GLdouble*, void> glTexGendv;

        /// <summary>void glTexGenf(GLenum coord, GLenum pname, GLfloat param)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureCoordName, TextureGenParameter, GLfloat, void> glTexGenf;

        /// <summary>void glTexGenfv(GLenum coord, GLenum pname, const GLfloat* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureCoordName, TextureGenParameter, GLfloat*, void> glTexGenfv;

        /// <summary>void glTexGeni(GLenum coord, GLenum pname, GLint param)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureCoordName, TextureGenParameter, GLint, void> glTexGeni;

        /// <summary>void glTexGeniv(GLenum coord, GLenum pname, const GLint* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureCoordName, TextureGenParameter, GLint*, void> glTexGeniv;

        /// <summary>void glTexImage1D(GLenum target, GLint level, GLint internalformat, GLsizei width, GLint border, GLenum format, GLenum type, const void* pixels)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLint, InternalFormat, GLsizei, GLint, PixelFormat, PixelType, void*, void> glTexImage1D;

#if !GL_ES_VERSION_2_0

        /// <summary>void glTexImage2D(GLenum target, GLint level, GLint internalformat, GLsizei width, GLsizei height, GLint border, GLenum format, GLenum type, const void* pixels)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLint, InternalFormat, GLsizei, GLsizei, GLint, PixelFormat, PixelType, void*, void> glTexImage2D;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)

        /// <summary>void glTexParameterf(GLenum target, GLenum pname, GLfloat param)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, TextureParameterName, GLfloat, void> glTexParameterf;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)

        /// <summary>void glTexParameterfv(GLenum target, GLenum pname, const GLfloat* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, TextureParameterName, GLfloat*, void> glTexParameterfv;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)

        /// <summary>void glTexParameteri(GLenum target, GLenum pname, GLint param)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, TextureParameterName, GLint, void> glTexParameteri;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)

        /// <summary>void glTexParameteriv(GLenum target, GLenum pname, const GLint* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, TextureParameterName, GLint*, void> glTexParameteriv;

#endif

        /// <summary>void glTranslated(GLdouble x, GLdouble y, GLdouble z)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLdouble, GLdouble, GLdouble, void> glTranslated;

        /// <summary>void glTranslatef(GLfloat x, GLfloat y, GLfloat z)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLfloat, GLfloat, void> glTranslatef;

        /// <summary>void glVertex2d(GLdouble x, GLdouble y)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLdouble, GLdouble, void> glVertex2d;

        /// <summary>void glVertex2dv(const GLdouble* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLdouble*, void> glVertex2dv;

        /// <summary>void glVertex2f(GLfloat x, GLfloat y)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLfloat, void> glVertex2f;

        /// <summary>void glVertex2fv(const GLfloat* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat*, void> glVertex2fv;

        /// <summary>void glVertex2i(GLint x, GLint y)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLint, void> glVertex2i;

        /// <summary>void glVertex2iv(const GLint* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint*, void> glVertex2iv;

        /// <summary>void glVertex2s(GLshort x, GLshort y)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLshort, GLshort, void> glVertex2s;

        /// <summary>void glVertex2sv(const GLshort* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLshort*, void> glVertex2sv;

        /// <summary>void glVertex3d(GLdouble x, GLdouble y, GLdouble z)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLdouble, GLdouble, GLdouble, void> glVertex3d;

        /// <summary>void glVertex3dv(const GLdouble* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLdouble*, void> glVertex3dv;

        /// <summary>void glVertex3f(GLfloat x, GLfloat y, GLfloat z)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLfloat, GLfloat, void> glVertex3f;

        /// <summary>void glVertex3fv(const GLfloat* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat*, void> glVertex3fv;

        /// <summary>void glVertex3i(GLint x, GLint y, GLint z)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLint, GLint, void> glVertex3i;

        /// <summary>void glVertex3iv(const GLint* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint*, void> glVertex3iv;

        /// <summary>void glVertex3s(GLshort x, GLshort y, GLshort z)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLshort, GLshort, GLshort, void> glVertex3s;

        /// <summary>void glVertex3sv(const GLshort* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLshort*, void> glVertex3sv;

        /// <summary>void glVertex4d(GLdouble x, GLdouble y, GLdouble z, GLdouble w)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLdouble, GLdouble, GLdouble, GLdouble, void> glVertex4d;

        /// <summary>void glVertex4dv(const GLdouble* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLdouble*, void> glVertex4dv;

        /// <summary>void glVertex4f(GLfloat x, GLfloat y, GLfloat z, GLfloat w)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLfloat, GLfloat, GLfloat, void> glVertex4f;

        /// <summary>void glVertex4fv(const GLfloat* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat*, void> glVertex4fv;

        /// <summary>void glVertex4i(GLint x, GLint y, GLint z, GLint w)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLint, GLint, GLint, void> glVertex4i;

        /// <summary>void glVertex4iv(const GLint* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint*, void> glVertex4iv;

        /// <summary>void glVertex4s(GLshort x, GLshort y, GLshort z, GLshort w)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLshort, GLshort, GLshort, GLshort, void> glVertex4s;

        /// <summary>void glVertex4sv(const GLshort* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLshort*, void> glVertex4sv;

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)

        /// <summary>void glViewport(GLint x, GLint y, GLsizei width, GLsizei height)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLint, GLsizei, GLsizei, void> glViewport;

#endif
    }
}
#endif