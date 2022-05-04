#if (GL_VERSION_1_0 && GL_API)
public partial class gl { 
    public partial class Functions { 
#if (!GL_SC_VERSION_2_0)
        /// <summary>void glAccum(GLenum op, GLfloat value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<AccumOp, GLfloat, void> glAccum;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glAlphaFunc(GLenum func, GLfloat ref);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<AlphaFunction, GLfloat, void> glAlphaFunc;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glBegin(GLenum mode);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, void> glBegin;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glBitmap(GLsizei width, GLsizei height, GLfloat xorig, GLfloat yorig, GLfloat xmove, GLfloat ymove, GLubyte* bitmap);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLsizei, GLfloat, GLfloat, GLfloat, GLfloat, GLubyte*, void> glBitmap;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glBlendFunc(GLenum sfactor, GLenum dfactor);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BlendingFactor, BlendingFactor, void> glBlendFunc;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glCallList(GLuint list);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, void> glCallList;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glCallLists(GLsizei n, GLenum type, void* lists);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, ListNameType, void*, void> glCallLists;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glClear(GLbitfield mask);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ClearBufferMask, void> glClear;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glClearAccum(GLfloat red, GLfloat green, GLfloat blue, GLfloat alpha);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLfloat, GLfloat, GLfloat, void> glClearAccum;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glClearColor(GLfloat red, GLfloat green, GLfloat blue, GLfloat alpha);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLfloat, GLfloat, GLfloat, void> glClearColor;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glClearDepth(GLdouble depth);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLdouble, void> glClearDepth;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glClearIndex(GLfloat c);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, void> glClearIndex;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glClearStencil(GLint s);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, void> glClearStencil;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glClipPlane(GLenum plane, GLdouble* equation);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ClipPlaneName, GLdouble*, void> glClipPlane;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glColor3b(GLbyte red, GLbyte green, GLbyte blue);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLbyte, GLbyte, GLbyte, void> glColor3b;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glColor3bv(GLbyte* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLbyte*, void> glColor3bv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glColor3d(GLdouble red, GLdouble green, GLdouble blue);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLdouble, GLdouble, GLdouble, void> glColor3d;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glColor3dv(GLdouble* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLdouble*, void> glColor3dv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glColor3f(GLfloat red, GLfloat green, GLfloat blue);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLfloat, GLfloat, void> glColor3f;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glColor3fv(GLfloat* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat*, void> glColor3fv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glColor3i(GLint red, GLint green, GLint blue);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLint, GLint, void> glColor3i;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glColor3iv(GLint* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint*, void> glColor3iv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glColor3s(GLshort red, GLshort green, GLshort blue);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLshort, GLshort, GLshort, void> glColor3s;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glColor3sv(GLshort* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLshort*, void> glColor3sv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glColor3ub(GLubyte red, GLubyte green, GLubyte blue);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLubyte, GLubyte, GLubyte, void> glColor3ub;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glColor3ubv(GLubyte* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLubyte*, void> glColor3ubv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glColor3ui(GLuint red, GLuint green, GLuint blue);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint, GLuint, void> glColor3ui;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glColor3uiv(GLuint* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint*, void> glColor3uiv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glColor3us(GLushort red, GLushort green, GLushort blue);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLushort, GLushort, GLushort, void> glColor3us;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glColor3usv(GLushort* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLushort*, void> glColor3usv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glColor4b(GLbyte red, GLbyte green, GLbyte blue, GLbyte alpha);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLbyte, GLbyte, GLbyte, GLbyte, void> glColor4b;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glColor4bv(GLbyte* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLbyte*, void> glColor4bv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glColor4d(GLdouble red, GLdouble green, GLdouble blue, GLdouble alpha);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLdouble, GLdouble, GLdouble, GLdouble, void> glColor4d;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glColor4dv(GLdouble* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLdouble*, void> glColor4dv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glColor4f(GLfloat red, GLfloat green, GLfloat blue, GLfloat alpha);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLfloat, GLfloat, GLfloat, void> glColor4f;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glColor4fv(GLfloat* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat*, void> glColor4fv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glColor4i(GLint red, GLint green, GLint blue, GLint alpha);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLint, GLint, GLint, void> glColor4i;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glColor4iv(GLint* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint*, void> glColor4iv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glColor4s(GLshort red, GLshort green, GLshort blue, GLshort alpha);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLshort, GLshort, GLshort, GLshort, void> glColor4s;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glColor4sv(GLshort* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLshort*, void> glColor4sv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glColor4ub(GLubyte red, GLubyte green, GLubyte blue, GLubyte alpha);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLubyte, GLubyte, GLubyte, GLubyte, void> glColor4ub;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glColor4ubv(GLubyte* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLubyte*, void> glColor4ubv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glColor4ui(GLuint red, GLuint green, GLuint blue, GLuint alpha);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint, GLuint, GLuint, void> glColor4ui;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glColor4uiv(GLuint* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint*, void> glColor4uiv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glColor4us(GLushort red, GLushort green, GLushort blue, GLushort alpha);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLushort, GLushort, GLushort, GLushort, void> glColor4us;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glColor4usv(GLushort* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLushort*, void> glColor4usv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glColorMask(GLboolean red, GLboolean green, GLboolean blue, GLboolean alpha);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLboolean, GLboolean, GLboolean, GLboolean, void> glColorMask;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glColorMaterial(GLenum face, GLenum mode);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MaterialFace, ColorMaterialParameter, void> glColorMaterial;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glCopyPixels(GLint x, GLint y, GLsizei width, GLsizei height, GLenum type);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLint, GLsizei, GLsizei, PixelCopyType, void> glCopyPixels;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glCullFace(GLenum mode);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<CullFaceMode, void> glCullFace;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glDeleteLists(GLuint list, GLsizei range);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<displaylist, GLsizei, void> glDeleteLists;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glDepthFunc(GLenum func);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<DepthFunction, void> glDepthFunc;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glDepthMask(GLboolean flag);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLboolean, void> glDepthMask;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glDepthRange(GLdouble n, GLdouble f);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLdouble, GLdouble, void> glDepthRange;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glDisable(GLenum cap);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<EnableCap, void> glDisable;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glDrawBuffer(GLenum buf);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<DrawBufferMode, void> glDrawBuffer;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glDrawPixels(GLsizei width, GLsizei height, GLenum format, GLenum type, void* pixels);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLsizei, PixelFormat, PixelType, void*, void> glDrawPixels;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glEdgeFlag(GLboolean flag);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLboolean, void> glEdgeFlag;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glEdgeFlagv(GLboolean* flag);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLboolean*, void> glEdgeFlagv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glEnable(GLenum cap);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<EnableCap, void> glEnable;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glEnd();</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void> glEnd;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glEndList();</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void> glEndList;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glEvalCoord1d(GLdouble u);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLdouble, void> glEvalCoord1d;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glEvalCoord1dv(GLdouble* u);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLdouble*, void> glEvalCoord1dv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glEvalCoord1f(GLfloat u);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, void> glEvalCoord1f;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glEvalCoord1fv(GLfloat* u);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat*, void> glEvalCoord1fv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glEvalCoord2d(GLdouble u, GLdouble v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLdouble, GLdouble, void> glEvalCoord2d;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glEvalCoord2dv(GLdouble* u);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLdouble*, void> glEvalCoord2dv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glEvalCoord2f(GLfloat u, GLfloat v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLfloat, void> glEvalCoord2f;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glEvalCoord2fv(GLfloat* u);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat*, void> glEvalCoord2fv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glEvalMesh1(GLenum mode, GLint i1, GLint i2);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MeshMode1, GLint, GLint, void> glEvalMesh1;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glEvalMesh2(GLenum mode, GLint i1, GLint i2, GLint j1, GLint j2);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MeshMode2, GLint, GLint, GLint, GLint, void> glEvalMesh2;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glEvalPoint1(GLint i);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, void> glEvalPoint1;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glEvalPoint2(GLint i, GLint j);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLint, void> glEvalPoint2;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glFeedbackBuffer(GLsizei size, GLenum type, GLfloat* buffer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, FeedbackType, GLfloat*, void> glFeedbackBuffer;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glFinish();</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void> glFinish;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glFlush();</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void> glFlush;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glFogf(GLenum pname, GLfloat param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FogParameter, GLfloat, void> glFogf;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glFogfv(GLenum pname, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FogParameter, GLfloat*, void> glFogfv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glFogi(GLenum pname, GLint param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FogParameter, GLint, void> glFogi;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glFogiv(GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FogParameter, GLint*, void> glFogiv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glFrontFace(GLenum mode);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FrontFaceDirection, void> glFrontFace;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glFrustum(GLdouble left, GLdouble right, GLdouble bottom, GLdouble top, GLdouble zNear, GLdouble zFar);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLdouble, GLdouble, GLdouble, GLdouble, GLdouble, GLdouble, void> glFrustum;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>GLuint glGenLists(GLsizei range);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, displaylist> glGenLists;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGetBooleanv(GLenum pname, GLboolean* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GetPName, GLboolean*, void> glGetBooleanv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGetClipPlane(GLenum plane, GLdouble* equation);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ClipPlaneName, GLdouble*, void> glGetClipPlane;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGetDoublev(GLenum pname, GLdouble* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GetPName, GLdouble*, void> glGetDoublev;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>GLenum glGetError();</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ErrorCode> glGetError;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGetFloatv(GLenum pname, GLfloat* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GetPName, GLfloat*, void> glGetFloatv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGetIntegerv(GLenum pname, GLint* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GetPName, GLint*, void> glGetIntegerv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGetLightfv(GLenum light, GLenum pname, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<LightName, LightParameter, GLfloat*, void> glGetLightfv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGetLightiv(GLenum light, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<LightName, LightParameter, GLint*, void> glGetLightiv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGetMapdv(GLenum target, GLenum query, GLdouble* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MapTarget, GetMapQuery, GLdouble*, void> glGetMapdv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGetMapfv(GLenum target, GLenum query, GLfloat* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MapTarget, GetMapQuery, GLfloat*, void> glGetMapfv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGetMapiv(GLenum target, GLenum query, GLint* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MapTarget, GetMapQuery, GLint*, void> glGetMapiv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGetMaterialfv(GLenum face, GLenum pname, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MaterialFace, MaterialParameter, GLfloat*, void> glGetMaterialfv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGetMaterialiv(GLenum face, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MaterialFace, MaterialParameter, GLint*, void> glGetMaterialiv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGetPixelMapfv(GLenum map, GLfloat* values);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PixelMap, GLfloat*, void> glGetPixelMapfv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGetPixelMapuiv(GLenum map, GLuint* values);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PixelMap, GLuint*, void> glGetPixelMapuiv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGetPixelMapusv(GLenum map, GLushort* values);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PixelMap, GLushort*, void> glGetPixelMapusv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGetPolygonStipple(GLubyte* mask);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLubyte*, void> glGetPolygonStipple;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>GLubyte* glGetString(GLenum name);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<StringName, GLubyte*> glGetString;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGetTexEnvfv(GLenum target, GLenum pname, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureEnvTarget, TextureEnvParameter, GLfloat*, void> glGetTexEnvfv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGetTexEnviv(GLenum target, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureEnvTarget, TextureEnvParameter, GLint*, void> glGetTexEnviv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGetTexGendv(GLenum coord, GLenum pname, GLdouble* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureCoordName, TextureGenParameter, GLdouble*, void> glGetTexGendv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGetTexGenfv(GLenum coord, GLenum pname, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureCoordName, TextureGenParameter, GLfloat*, void> glGetTexGenfv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGetTexGeniv(GLenum coord, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureCoordName, TextureGenParameter, GLint*, void> glGetTexGeniv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGetTexImage(GLenum target, GLint level, GLenum format, GLenum type, void* pixels);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLint, PixelFormat, PixelType, void*, void> glGetTexImage;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGetTexLevelParameterfv(GLenum target, GLint level, GLenum pname, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLint, GetTextureParameter, GLfloat*, void> glGetTexLevelParameterfv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGetTexLevelParameteriv(GLenum target, GLint level, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLint, GetTextureParameter, GLint*, void> glGetTexLevelParameteriv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGetTexParameterfv(GLenum target, GLenum pname, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GetTextureParameter, GLfloat*, void> glGetTexParameterfv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGetTexParameteriv(GLenum target, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GetTextureParameter, GLint*, void> glGetTexParameteriv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glHint(GLenum target, GLenum mode);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<HintTarget, HintMode, void> glHint;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glIndexd(GLdouble c);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLdouble, void> glIndexd;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glIndexdv(GLdouble* c);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLdouble*, void> glIndexdv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glIndexf(GLfloat c);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, void> glIndexf;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glIndexfv(GLfloat* c);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat*, void> glIndexfv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glIndexi(GLint c);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, void> glIndexi;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glIndexiv(GLint* c);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint*, void> glIndexiv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glIndexMask(GLuint mask);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, void> glIndexMask;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glIndexs(GLshort c);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLshort, void> glIndexs;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glIndexsv(GLshort* c);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLshort*, void> glIndexsv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glInitNames();</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void> glInitNames;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>GLboolean glIsEnabled(GLenum cap);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<EnableCap, GLboolean> glIsEnabled;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>GLboolean glIsList(GLuint list);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<displaylist, GLboolean> glIsList;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glLightf(GLenum light, GLenum pname, GLfloat param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<LightName, LightParameter, GLfloat, void> glLightf;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glLightfv(GLenum light, GLenum pname, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<LightName, LightParameter, GLfloat*, void> glLightfv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glLighti(GLenum light, GLenum pname, GLint param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<LightName, LightParameter, GLint, void> glLighti;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glLightiv(GLenum light, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<LightName, LightParameter, GLint*, void> glLightiv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glLightModelf(GLenum pname, GLfloat param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<LightModelParameter, GLfloat, void> glLightModelf;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glLightModelfv(GLenum pname, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<LightModelParameter, GLfloat*, void> glLightModelfv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glLightModeli(GLenum pname, GLint param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<LightModelParameter, GLint, void> glLightModeli;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glLightModeliv(GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<LightModelParameter, GLint*, void> glLightModeliv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glLineStipple(GLint factor, GLushort pattern);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLushort, void> glLineStipple;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glLineWidth(GLfloat width);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, void> glLineWidth;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glListBase(GLuint base);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, void> glListBase;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glLoadIdentity();</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void> glLoadIdentity;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glLoadMatrixd(GLdouble* m);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLdouble*, void> glLoadMatrixd;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glLoadMatrixf(GLfloat* m);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat*, void> glLoadMatrixf;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glLoadName(GLuint name);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, void> glLoadName;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glLogicOp(GLenum opcode);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<LogicOp, void> glLogicOp;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glMap1d(GLenum target, GLdouble u1, GLdouble u2, GLint stride, GLint order, GLdouble* points);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MapTarget, GLdouble, GLdouble, GLint, GLint, GLdouble*, void> glMap1d;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glMap1f(GLenum target, GLfloat u1, GLfloat u2, GLint stride, GLint order, GLfloat* points);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MapTarget, GLfloat, GLfloat, GLint, GLint, GLfloat*, void> glMap1f;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glMap2d(GLenum target, GLdouble u1, GLdouble u2, GLint ustride, GLint uorder, GLdouble v1, GLdouble v2, GLint vstride, GLint vorder, GLdouble* points);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MapTarget, GLdouble, GLdouble, GLint, GLint, GLdouble, GLdouble, GLint, GLint, GLdouble*, void> glMap2d;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glMap2f(GLenum target, GLfloat u1, GLfloat u2, GLint ustride, GLint uorder, GLfloat v1, GLfloat v2, GLint vstride, GLint vorder, GLfloat* points);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MapTarget, GLfloat, GLfloat, GLint, GLint, GLfloat, GLfloat, GLint, GLint, GLfloat*, void> glMap2f;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glMapGrid1d(GLint un, GLdouble u1, GLdouble u2);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLdouble, GLdouble, void> glMapGrid1d;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glMapGrid1f(GLint un, GLfloat u1, GLfloat u2);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLfloat, GLfloat, void> glMapGrid1f;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glMapGrid2d(GLint un, GLdouble u1, GLdouble u2, GLint vn, GLdouble v1, GLdouble v2);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLdouble, GLdouble, GLint, GLdouble, GLdouble, void> glMapGrid2d;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glMapGrid2f(GLint un, GLfloat u1, GLfloat u2, GLint vn, GLfloat v1, GLfloat v2);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLfloat, GLfloat, GLint, GLfloat, GLfloat, void> glMapGrid2f;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glMaterialf(GLenum face, GLenum pname, GLfloat param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MaterialFace, MaterialParameter, GLfloat, void> glMaterialf;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glMaterialfv(GLenum face, GLenum pname, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MaterialFace, MaterialParameter, GLfloat*, void> glMaterialfv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glMateriali(GLenum face, GLenum pname, GLint param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MaterialFace, MaterialParameter, GLint, void> glMateriali;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glMaterialiv(GLenum face, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MaterialFace, MaterialParameter, GLint*, void> glMaterialiv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glMatrixMode(GLenum mode);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MatrixMode, void> glMatrixMode;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glMultMatrixd(GLdouble* m);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLdouble*, void> glMultMatrixd;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glMultMatrixf(GLfloat* m);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat*, void> glMultMatrixf;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glNewList(GLuint list, GLenum mode);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, ListMode, void> glNewList;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glNormal3b(GLbyte nx, GLbyte ny, GLbyte nz);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLbyte, GLbyte, GLbyte, void> glNormal3b;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glNormal3bv(GLbyte* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLbyte*, void> glNormal3bv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glNormal3d(GLdouble nx, GLdouble ny, GLdouble nz);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLdouble, GLdouble, GLdouble, void> glNormal3d;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glNormal3dv(GLdouble* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLdouble*, void> glNormal3dv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glNormal3f(GLfloat nx, GLfloat ny, GLfloat nz);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLfloat, GLfloat, void> glNormal3f;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glNormal3fv(GLfloat* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat*, void> glNormal3fv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glNormal3i(GLint nx, GLint ny, GLint nz);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLint, GLint, void> glNormal3i;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glNormal3iv(GLint* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint*, void> glNormal3iv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glNormal3s(GLshort nx, GLshort ny, GLshort nz);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLshort, GLshort, GLshort, void> glNormal3s;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glNormal3sv(GLshort* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLshort*, void> glNormal3sv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glOrtho(GLdouble left, GLdouble right, GLdouble bottom, GLdouble top, GLdouble zNear, GLdouble zFar);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLdouble, GLdouble, GLdouble, GLdouble, GLdouble, GLdouble, void> glOrtho;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glPassThrough(GLfloat token);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, void> glPassThrough;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glPixelMapfv(GLenum map, GLsizei mapsize, GLfloat* values);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PixelMap, GLsizei, GLfloat*, void> glPixelMapfv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glPixelMapuiv(GLenum map, GLsizei mapsize, GLuint* values);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PixelMap, GLsizei, GLuint*, void> glPixelMapuiv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glPixelMapusv(GLenum map, GLsizei mapsize, GLushort* values);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PixelMap, GLsizei, GLushort*, void> glPixelMapusv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glPixelStoref(GLenum pname, GLfloat param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PixelStoreParameter, GLfloat, void> glPixelStoref;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glPixelStorei(GLenum pname, GLint param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PixelStoreParameter, GLint, void> glPixelStorei;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glPixelTransferf(GLenum pname, GLfloat param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PixelTransferParameter, GLfloat, void> glPixelTransferf;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glPixelTransferi(GLenum pname, GLint param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PixelTransferParameter, GLint, void> glPixelTransferi;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glPixelZoom(GLfloat xfactor, GLfloat yfactor);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLfloat, void> glPixelZoom;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glPointSize(GLfloat size);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, void> glPointSize;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glPolygonMode(GLenum face, GLenum mode);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MaterialFace, PolygonMode, void> glPolygonMode;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glPolygonStipple(GLubyte* mask);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLubyte*, void> glPolygonStipple;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glPopAttrib();</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void> glPopAttrib;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glPopMatrix();</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void> glPopMatrix;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glPopName();</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void> glPopName;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glPushAttrib(GLbitfield mask);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<AttribMask, void> glPushAttrib;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glPushMatrix();</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void> glPushMatrix;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glPushName(GLuint name);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, void> glPushName;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glRasterPos2d(GLdouble x, GLdouble y);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLdouble, GLdouble, void> glRasterPos2d;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glRasterPos2dv(GLdouble* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLdouble*, void> glRasterPos2dv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glRasterPos2f(GLfloat x, GLfloat y);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLfloat, void> glRasterPos2f;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glRasterPos2fv(GLfloat* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat*, void> glRasterPos2fv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glRasterPos2i(GLint x, GLint y);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLint, void> glRasterPos2i;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glRasterPos2iv(GLint* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint*, void> glRasterPos2iv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glRasterPos2s(GLshort x, GLshort y);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLshort, GLshort, void> glRasterPos2s;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glRasterPos2sv(GLshort* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLshort*, void> glRasterPos2sv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glRasterPos3d(GLdouble x, GLdouble y, GLdouble z);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLdouble, GLdouble, GLdouble, void> glRasterPos3d;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glRasterPos3dv(GLdouble* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLdouble*, void> glRasterPos3dv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glRasterPos3f(GLfloat x, GLfloat y, GLfloat z);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLfloat, GLfloat, void> glRasterPos3f;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glRasterPos3fv(GLfloat* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat*, void> glRasterPos3fv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glRasterPos3i(GLint x, GLint y, GLint z);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLint, GLint, void> glRasterPos3i;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glRasterPos3iv(GLint* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint*, void> glRasterPos3iv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glRasterPos3s(GLshort x, GLshort y, GLshort z);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLshort, GLshort, GLshort, void> glRasterPos3s;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glRasterPos3sv(GLshort* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLshort*, void> glRasterPos3sv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glRasterPos4d(GLdouble x, GLdouble y, GLdouble z, GLdouble w);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLdouble, GLdouble, GLdouble, GLdouble, void> glRasterPos4d;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glRasterPos4dv(GLdouble* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLdouble*, void> glRasterPos4dv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glRasterPos4f(GLfloat x, GLfloat y, GLfloat z, GLfloat w);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLfloat, GLfloat, GLfloat, void> glRasterPos4f;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glRasterPos4fv(GLfloat* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat*, void> glRasterPos4fv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glRasterPos4i(GLint x, GLint y, GLint z, GLint w);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLint, GLint, GLint, void> glRasterPos4i;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glRasterPos4iv(GLint* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint*, void> glRasterPos4iv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glRasterPos4s(GLshort x, GLshort y, GLshort z, GLshort w);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLshort, GLshort, GLshort, GLshort, void> glRasterPos4s;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glRasterPos4sv(GLshort* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLshort*, void> glRasterPos4sv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glReadBuffer(GLenum src);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ReadBufferMode, void> glReadBuffer;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glReadPixels(GLint x, GLint y, GLsizei width, GLsizei height, GLenum format, GLenum type, void* pixels);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLint, GLsizei, GLsizei, PixelFormat, PixelType, void*, void> glReadPixels;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glRectd(GLdouble x1, GLdouble y1, GLdouble x2, GLdouble y2);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLdouble, GLdouble, GLdouble, GLdouble, void> glRectd;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glRectdv(GLdouble* v1, GLdouble* v2);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLdouble*, GLdouble*, void> glRectdv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glRectf(GLfloat x1, GLfloat y1, GLfloat x2, GLfloat y2);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLfloat, GLfloat, GLfloat, void> glRectf;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glRectfv(GLfloat* v1, GLfloat* v2);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat*, GLfloat*, void> glRectfv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glRecti(GLint x1, GLint y1, GLint x2, GLint y2);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLint, GLint, GLint, void> glRecti;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glRectiv(GLint* v1, GLint* v2);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint*, GLint*, void> glRectiv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glRects(GLshort x1, GLshort y1, GLshort x2, GLshort y2);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLshort, GLshort, GLshort, GLshort, void> glRects;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glRectsv(GLshort* v1, GLshort* v2);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLshort*, GLshort*, void> glRectsv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>GLint glRenderMode(GLenum mode);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<RenderingMode, GLint> glRenderMode;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glRotated(GLdouble angle, GLdouble x, GLdouble y, GLdouble z);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLdouble, GLdouble, GLdouble, GLdouble, void> glRotated;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glRotatef(GLfloat angle, GLfloat x, GLfloat y, GLfloat z);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLfloat, GLfloat, GLfloat, void> glRotatef;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glScaled(GLdouble x, GLdouble y, GLdouble z);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLdouble, GLdouble, GLdouble, void> glScaled;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glScalef(GLfloat x, GLfloat y, GLfloat z);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLfloat, GLfloat, void> glScalef;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glScissor(GLint x, GLint y, GLsizei width, GLsizei height);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLint, GLsizei, GLsizei, void> glScissor;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glSelectBuffer(GLsizei size, GLuint* buffer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLuint*, void> glSelectBuffer;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glShadeModel(GLenum mode);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ShadingModel, void> glShadeModel;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glStencilFunc(GLenum func, GLint ref, GLuint mask);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<StencilFunction, GLint, GLuint, void> glStencilFunc;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glStencilMask(GLuint mask);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, void> glStencilMask;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glStencilOp(GLenum fail, GLenum zfail, GLenum zpass);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<StencilOp, StencilOp, StencilOp, void> glStencilOp;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glTexCoord1d(GLdouble s);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLdouble, void> glTexCoord1d;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glTexCoord1dv(GLdouble* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLdouble*, void> glTexCoord1dv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glTexCoord1f(GLfloat s);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, void> glTexCoord1f;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glTexCoord1fv(GLfloat* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat*, void> glTexCoord1fv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glTexCoord1i(GLint s);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, void> glTexCoord1i;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glTexCoord1iv(GLint* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint*, void> glTexCoord1iv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glTexCoord1s(GLshort s);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLshort, void> glTexCoord1s;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glTexCoord1sv(GLshort* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLshort*, void> glTexCoord1sv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glTexCoord2d(GLdouble s, GLdouble t);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLdouble, GLdouble, void> glTexCoord2d;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glTexCoord2dv(GLdouble* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLdouble*, void> glTexCoord2dv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glTexCoord2f(GLfloat s, GLfloat t);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLfloat, void> glTexCoord2f;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glTexCoord2fv(GLfloat* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat*, void> glTexCoord2fv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glTexCoord2i(GLint s, GLint t);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLint, void> glTexCoord2i;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glTexCoord2iv(GLint* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint*, void> glTexCoord2iv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glTexCoord2s(GLshort s, GLshort t);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLshort, GLshort, void> glTexCoord2s;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glTexCoord2sv(GLshort* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLshort*, void> glTexCoord2sv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glTexCoord3d(GLdouble s, GLdouble t, GLdouble r);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLdouble, GLdouble, GLdouble, void> glTexCoord3d;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glTexCoord3dv(GLdouble* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLdouble*, void> glTexCoord3dv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glTexCoord3f(GLfloat s, GLfloat t, GLfloat r);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLfloat, GLfloat, void> glTexCoord3f;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glTexCoord3fv(GLfloat* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat*, void> glTexCoord3fv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glTexCoord3i(GLint s, GLint t, GLint r);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLint, GLint, void> glTexCoord3i;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glTexCoord3iv(GLint* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint*, void> glTexCoord3iv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glTexCoord3s(GLshort s, GLshort t, GLshort r);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLshort, GLshort, GLshort, void> glTexCoord3s;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glTexCoord3sv(GLshort* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLshort*, void> glTexCoord3sv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glTexCoord4d(GLdouble s, GLdouble t, GLdouble r, GLdouble q);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLdouble, GLdouble, GLdouble, GLdouble, void> glTexCoord4d;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glTexCoord4dv(GLdouble* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLdouble*, void> glTexCoord4dv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glTexCoord4f(GLfloat s, GLfloat t, GLfloat r, GLfloat q);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLfloat, GLfloat, GLfloat, void> glTexCoord4f;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glTexCoord4fv(GLfloat* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat*, void> glTexCoord4fv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glTexCoord4i(GLint s, GLint t, GLint r, GLint q);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLint, GLint, GLint, void> glTexCoord4i;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glTexCoord4iv(GLint* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint*, void> glTexCoord4iv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glTexCoord4s(GLshort s, GLshort t, GLshort r, GLshort q);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLshort, GLshort, GLshort, GLshort, void> glTexCoord4s;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glTexCoord4sv(GLshort* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLshort*, void> glTexCoord4sv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glTexEnvf(GLenum target, GLenum pname, GLfloat param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureEnvTarget, TextureEnvParameter, GLfloat, void> glTexEnvf;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glTexEnvfv(GLenum target, GLenum pname, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureEnvTarget, TextureEnvParameter, GLfloat*, void> glTexEnvfv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glTexEnvi(GLenum target, GLenum pname, GLint param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureEnvTarget, TextureEnvParameter, GLint, void> glTexEnvi;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glTexEnviv(GLenum target, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureEnvTarget, TextureEnvParameter, GLint*, void> glTexEnviv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glTexGend(GLenum coord, GLenum pname, GLdouble param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureCoordName, TextureGenParameter, GLdouble, void> glTexGend;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glTexGendv(GLenum coord, GLenum pname, GLdouble* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureCoordName, TextureGenParameter, GLdouble*, void> glTexGendv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glTexGenf(GLenum coord, GLenum pname, GLfloat param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureCoordName, TextureGenParameter, GLfloat, void> glTexGenf;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glTexGenfv(GLenum coord, GLenum pname, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureCoordName, TextureGenParameter, GLfloat*, void> glTexGenfv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glTexGeni(GLenum coord, GLenum pname, GLint param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureCoordName, TextureGenParameter, GLint, void> glTexGeni;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glTexGeniv(GLenum coord, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureCoordName, TextureGenParameter, GLint*, void> glTexGeniv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glTexImage1D(GLenum target, GLint level, GLint internalformat, GLsizei width, GLint border, GLenum format, GLenum type, void* pixels);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLint, InternalFormat, GLsizei, GLint, PixelFormat, PixelType, void*, void> glTexImage1D;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glTexImage2D(GLenum target, GLint level, GLint internalformat, GLsizei width, GLsizei height, GLint border, GLenum format, GLenum type, void* pixels);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLint, InternalFormat, GLsizei, GLsizei, GLint, PixelFormat, PixelType, void*, void> glTexImage2D;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glTexParameterf(GLenum target, GLenum pname, GLfloat param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, TextureParameterName, GLfloat, void> glTexParameterf;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glTexParameterfv(GLenum target, GLenum pname, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, TextureParameterName, GLfloat*, void> glTexParameterfv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glTexParameteri(GLenum target, GLenum pname, GLint param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, TextureParameterName, GLint, void> glTexParameteri;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glTexParameteriv(GLenum target, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, TextureParameterName, GLint*, void> glTexParameteriv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glTranslated(GLdouble x, GLdouble y, GLdouble z);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLdouble, GLdouble, GLdouble, void> glTranslated;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glTranslatef(GLfloat x, GLfloat y, GLfloat z);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLfloat, GLfloat, void> glTranslatef;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glVertex2d(GLdouble x, GLdouble y);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLdouble, GLdouble, void> glVertex2d;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glVertex2dv(GLdouble* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLdouble*, void> glVertex2dv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glVertex2f(GLfloat x, GLfloat y);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLfloat, void> glVertex2f;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glVertex2fv(GLfloat* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat*, void> glVertex2fv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glVertex2i(GLint x, GLint y);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLint, void> glVertex2i;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glVertex2iv(GLint* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint*, void> glVertex2iv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glVertex2s(GLshort x, GLshort y);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLshort, GLshort, void> glVertex2s;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glVertex2sv(GLshort* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLshort*, void> glVertex2sv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glVertex3d(GLdouble x, GLdouble y, GLdouble z);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLdouble, GLdouble, GLdouble, void> glVertex3d;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glVertex3dv(GLdouble* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLdouble*, void> glVertex3dv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glVertex3f(GLfloat x, GLfloat y, GLfloat z);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLfloat, GLfloat, void> glVertex3f;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glVertex3fv(GLfloat* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat*, void> glVertex3fv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glVertex3i(GLint x, GLint y, GLint z);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLint, GLint, void> glVertex3i;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glVertex3iv(GLint* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint*, void> glVertex3iv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glVertex3s(GLshort x, GLshort y, GLshort z);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLshort, GLshort, GLshort, void> glVertex3s;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glVertex3sv(GLshort* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLshort*, void> glVertex3sv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glVertex4d(GLdouble x, GLdouble y, GLdouble z, GLdouble w);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLdouble, GLdouble, GLdouble, GLdouble, void> glVertex4d;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glVertex4dv(GLdouble* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLdouble*, void> glVertex4dv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glVertex4f(GLfloat x, GLfloat y, GLfloat z, GLfloat w);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLfloat, GLfloat, GLfloat, void> glVertex4f;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glVertex4fv(GLfloat* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat*, void> glVertex4fv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glVertex4i(GLint x, GLint y, GLint z, GLint w);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLint, GLint, GLint, void> glVertex4i;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glVertex4iv(GLint* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint*, void> glVertex4iv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glVertex4s(GLshort x, GLshort y, GLshort z, GLshort w);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLshort, GLshort, GLshort, GLshort, void> glVertex4s;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glVertex4sv(GLshort* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLshort*, void> glVertex4sv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glViewport(GLint x, GLint y, GLsizei width, GLsizei height);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLint, GLsizei, GLsizei, void> glViewport;
#endif
    }
}
#endif