#if (GL_VERSION_ES_CM_1_0 && GLES1_API)
public partial class gles1 { 
    public partial class Functions { 
        /// <summary>void glActiveTexture(GLenum texture);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, void> glActiveTexture;

        /// <summary>void glAlphaFunc(GLenum func, GLfloat ref);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<AlphaFunction, GLfloat, void> glAlphaFunc;

        /// <summary>void glAlphaFuncx(GLenum func, GLfixed ref);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<AlphaFunction, GLfixed, void> glAlphaFuncx;

        /// <summary>void glBindBuffer(GLenum target, GLuint buffer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BufferTargetARB, GLbuffer, void> glBindBuffer;

        /// <summary>void glBindTexture(GLenum target, GLuint texture);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLtexture, void> glBindTexture;

        /// <summary>void glBlendFunc(GLenum sfactor, GLenum dfactor);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BlendingFactor, BlendingFactor, void> glBlendFunc;

        /// <summary>void glBufferData(GLenum target, GLsizeiptr size, void* data, GLenum usage);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BufferTargetARB, GLsizeiptr, void*, BufferUsageARB, void> glBufferData;

        /// <summary>void glBufferSubData(GLenum target, GLintptr offset, GLsizeiptr size, void* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BufferTargetARB, GLintptr, GLsizeiptr, void*, void> glBufferSubData;

        /// <summary>void glClear(GLbitfield mask);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ClearBufferMask, void> glClear;

        /// <summary>void glClearColor(GLfloat red, GLfloat green, GLfloat blue, GLfloat alpha);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLfloat, GLfloat, GLfloat, void> glClearColor;

        /// <summary>void glClearColorx(GLfixed red, GLfixed green, GLfixed blue, GLfixed alpha);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfixed, GLfixed, GLfixed, GLfixed, void> glClearColorx;

        /// <summary>void glClearDepthf(GLfloat d);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, void> glClearDepthf;

        /// <summary>void glClearDepthx(GLfixed depth);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfixed, void> glClearDepthx;

        /// <summary>void glClearStencil(GLint s);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, void> glClearStencil;

        /// <summary>void glClientActiveTexture(GLenum texture);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, void> glClientActiveTexture;

        /// <summary>void glClipPlanef(GLenum p, GLfloat* eqn);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ClipPlaneName, GLfloat*, void> glClipPlanef;

        /// <summary>void glClipPlanex(GLenum plane, GLfixed* equation);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ClipPlaneName, GLfixed*, void> glClipPlanex;

        /// <summary>void glColor4f(GLfloat red, GLfloat green, GLfloat blue, GLfloat alpha);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLfloat, GLfloat, GLfloat, void> glColor4f;

        /// <summary>void glColor4ub(GLubyte red, GLubyte green, GLubyte blue, GLubyte alpha);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLubyte, GLubyte, GLubyte, GLubyte, void> glColor4ub;

        /// <summary>void glColor4x(GLfixed red, GLfixed green, GLfixed blue, GLfixed alpha);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfixed, GLfixed, GLfixed, GLfixed, void> glColor4x;

        /// <summary>void glColorMask(GLboolean red, GLboolean green, GLboolean blue, GLboolean alpha);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLboolean, GLboolean, GLboolean, GLboolean, void> glColorMask;

        /// <summary>void glColorPointer(GLint size, GLenum type, GLsizei stride, void* pointer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, ColorPointerType, GLsizei, void*, void> glColorPointer;

        /// <summary>void glCompressedTexImage2D(GLenum target, GLint level, GLenum internalformat, GLsizei width, GLsizei height, GLint border, GLsizei imageSize, void* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLint, InternalFormat, GLsizei, GLsizei, GLint, GLsizei, void*, void> glCompressedTexImage2D;

        /// <summary>void glCompressedTexSubImage2D(GLenum target, GLint level, GLint xoffset, GLint yoffset, GLsizei width, GLsizei height, GLenum format, GLsizei imageSize, void* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLint, GLint, GLint, GLsizei, GLsizei, InternalFormat, GLsizei, void*, void> glCompressedTexSubImage2D;

        /// <summary>void glCopyTexImage2D(GLenum target, GLint level, GLenum internalformat, GLint x, GLint y, GLsizei width, GLsizei height, GLint border);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLint, InternalFormat, GLint, GLint, GLsizei, GLsizei, GLint, void> glCopyTexImage2D;

        /// <summary>void glCopyTexSubImage2D(GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint x, GLint y, GLsizei width, GLsizei height);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLint, GLint, GLint, GLint, GLint, GLsizei, GLsizei, void> glCopyTexSubImage2D;

        /// <summary>void glCullFace(GLenum mode);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<CullFaceMode, void> glCullFace;

        /// <summary>void glDeleteBuffers(GLsizei n, GLuint* buffers);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLbuffer*, void> glDeleteBuffers;

        /// <summary>void glDeleteTextures(GLsizei n, GLuint* textures);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLtexture*, void> glDeleteTextures;

        /// <summary>void glDepthFunc(GLenum func);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<DepthFunction, void> glDepthFunc;

        /// <summary>void glDepthMask(GLboolean flag);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLboolean, void> glDepthMask;

        /// <summary>void glDepthRangef(GLfloat n, GLfloat f);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLfloat, void> glDepthRangef;

        /// <summary>void glDepthRangex(GLfixed n, GLfixed f);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfixed, GLfixed, void> glDepthRangex;

        /// <summary>void glDisable(GLenum cap);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<EnableCap, void> glDisable;

        /// <summary>void glDisableClientState(GLenum array);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<EnableCap, void> glDisableClientState;

        /// <summary>void glDrawArrays(GLenum mode, GLint first, GLsizei count);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, GLint, GLsizei, void> glDrawArrays;

        /// <summary>void glDrawElements(GLenum mode, GLsizei count, GLenum type, void* indices);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, GLsizei, DrawElementsType, void*, void> glDrawElements;

        /// <summary>void glEnable(GLenum cap);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<EnableCap, void> glEnable;

        /// <summary>void glEnableClientState(GLenum array);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<EnableCap, void> glEnableClientState;

        /// <summary>void glFinish();</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void> glFinish;

        /// <summary>void glFlush();</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void> glFlush;

        /// <summary>void glFogf(GLenum pname, GLfloat param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FogParameter, GLfloat, void> glFogf;

        /// <summary>void glFogfv(GLenum pname, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FogParameter, GLfloat*, void> glFogfv;

        /// <summary>void glFogx(GLenum pname, GLfixed param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FogPName, GLfixed, void> glFogx;

        /// <summary>void glFogxv(GLenum pname, GLfixed* param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FogPName, GLfixed*, void> glFogxv;

        /// <summary>void glFrontFace(GLenum mode);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FrontFaceDirection, void> glFrontFace;

        /// <summary>void glFrustumf(GLfloat l, GLfloat r, GLfloat b, GLfloat t, GLfloat n, GLfloat f);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, void> glFrustumf;

        /// <summary>void glFrustumx(GLfixed l, GLfixed r, GLfixed b, GLfixed t, GLfixed n, GLfixed f);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfixed, GLfixed, GLfixed, GLfixed, GLfixed, GLfixed, void> glFrustumx;

        /// <summary>void glGenBuffers(GLsizei n, GLuint* buffers);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLbuffer*, void> glGenBuffers;

        /// <summary>void glGenTextures(GLsizei n, GLuint* textures);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLtexture*, void> glGenTextures;

        /// <summary>void glGetBooleanv(GLenum pname, GLboolean* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GetPName, GLboolean*, void> glGetBooleanv;

        /// <summary>void glGetBufferParameteriv(GLenum target, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BufferTargetARB, BufferPNameARB, GLint*, void> glGetBufferParameteriv;

        /// <summary>void glGetClipPlanef(GLenum plane, GLfloat* equation);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ClipPlaneName, GLfloat*, void> glGetClipPlanef;

        /// <summary>void glGetClipPlanex(GLenum plane, GLfixed* equation);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ClipPlaneName, GLfixed*, void> glGetClipPlanex;

        /// <summary>GLenum glGetError();</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ErrorCode> glGetError;

        /// <summary>void glGetFixedv(GLenum pname, GLfixed* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GetPName, GLfixed*, void> glGetFixedv;

        /// <summary>void glGetFloatv(GLenum pname, GLfloat* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GetPName, GLfloat*, void> glGetFloatv;

        /// <summary>void glGetIntegerv(GLenum pname, GLint* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GetPName, GLint*, void> glGetIntegerv;

        /// <summary>void glGetLightfv(GLenum light, GLenum pname, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<LightName, LightParameter, GLfloat*, void> glGetLightfv;

        /// <summary>void glGetLightxv(GLenum light, GLenum pname, GLfixed* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<LightName, LightParameter, GLfixed*, void> glGetLightxv;

        /// <summary>void glGetMaterialfv(GLenum face, GLenum pname, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MaterialFace, MaterialParameter, GLfloat*, void> glGetMaterialfv;

        /// <summary>void glGetMaterialxv(GLenum face, GLenum pname, GLfixed* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MaterialFace, MaterialParameter, GLfixed*, void> glGetMaterialxv;

        /// <summary>void glGetPointerv(GLenum pname, void** params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GetPointervPName, void**, void> glGetPointerv;

        /// <summary>GLubyte* glGetString(GLenum name);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<StringName, GLubyte*> glGetString;

        /// <summary>void glGetTexEnvfv(GLenum target, GLenum pname, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureEnvTarget, TextureEnvParameter, GLfloat*, void> glGetTexEnvfv;

        /// <summary>void glGetTexEnviv(GLenum target, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureEnvTarget, TextureEnvParameter, GLint*, void> glGetTexEnviv;

        /// <summary>void glGetTexEnvxv(GLenum target, GLenum pname, GLfixed* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureEnvTarget, TextureEnvParameter, GLfixed*, void> glGetTexEnvxv;

        /// <summary>void glGetTexParameterfv(GLenum target, GLenum pname, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GetTextureParameter, GLfloat*, void> glGetTexParameterfv;

        /// <summary>void glGetTexParameteriv(GLenum target, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GetTextureParameter, GLint*, void> glGetTexParameteriv;

        /// <summary>void glGetTexParameterxv(GLenum target, GLenum pname, GLfixed* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GetTextureParameter, GLfixed*, void> glGetTexParameterxv;

        /// <summary>void glHint(GLenum target, GLenum mode);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<HintTarget, HintMode, void> glHint;

        /// <summary>GLboolean glIsBuffer(GLuint buffer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLbuffer, GLboolean> glIsBuffer;

        /// <summary>GLboolean glIsEnabled(GLenum cap);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<EnableCap, GLboolean> glIsEnabled;

        /// <summary>GLboolean glIsTexture(GLuint texture);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLtexture, GLboolean> glIsTexture;

        /// <summary>void glLightf(GLenum light, GLenum pname, GLfloat param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<LightName, LightParameter, GLfloat, void> glLightf;

        /// <summary>void glLightfv(GLenum light, GLenum pname, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<LightName, LightParameter, GLfloat*, void> glLightfv;

        /// <summary>void glLightModelf(GLenum pname, GLfloat param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<LightModelParameter, GLfloat, void> glLightModelf;

        /// <summary>void glLightModelfv(GLenum pname, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<LightModelParameter, GLfloat*, void> glLightModelfv;

        /// <summary>void glLightModelx(GLenum pname, GLfixed param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<LightModelParameter, GLfixed, void> glLightModelx;

        /// <summary>void glLightModelxv(GLenum pname, GLfixed* param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<LightModelParameter, GLfixed*, void> glLightModelxv;

        /// <summary>void glLightx(GLenum light, GLenum pname, GLfixed param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<LightName, LightParameter, GLfixed, void> glLightx;

        /// <summary>void glLightxv(GLenum light, GLenum pname, GLfixed* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<LightName, LightParameter, GLfixed*, void> glLightxv;

        /// <summary>void glLineWidth(GLfloat width);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, void> glLineWidth;

        /// <summary>void glLineWidthx(GLfixed width);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfixed, void> glLineWidthx;

        /// <summary>void glLoadIdentity();</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void> glLoadIdentity;

        /// <summary>void glLoadMatrixf(GLfloat* m);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat*, void> glLoadMatrixf;

        /// <summary>void glLoadMatrixx(GLfixed* m);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfixed*, void> glLoadMatrixx;

        /// <summary>void glLogicOp(GLenum opcode);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<LogicOp, void> glLogicOp;

        /// <summary>void glMaterialf(GLenum face, GLenum pname, GLfloat param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MaterialFace, MaterialParameter, GLfloat, void> glMaterialf;

        /// <summary>void glMaterialfv(GLenum face, GLenum pname, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MaterialFace, MaterialParameter, GLfloat*, void> glMaterialfv;

        /// <summary>void glMaterialx(GLenum face, GLenum pname, GLfixed param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MaterialFace, MaterialParameter, GLfixed, void> glMaterialx;

        /// <summary>void glMaterialxv(GLenum face, GLenum pname, GLfixed* param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MaterialFace, MaterialParameter, GLfixed*, void> glMaterialxv;

        /// <summary>void glMatrixMode(GLenum mode);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MatrixMode, void> glMatrixMode;

        /// <summary>void glMultiTexCoord4f(GLenum target, GLfloat s, GLfloat t, GLfloat r, GLfloat q);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLfloat, GLfloat, GLfloat, GLfloat, void> glMultiTexCoord4f;

        /// <summary>void glMultiTexCoord4x(GLenum texture, GLfixed s, GLfixed t, GLfixed r, GLfixed q);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLfixed, GLfixed, GLfixed, GLfixed, void> glMultiTexCoord4x;

        /// <summary>void glMultMatrixf(GLfloat* m);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat*, void> glMultMatrixf;

        /// <summary>void glMultMatrixx(GLfixed* m);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfixed*, void> glMultMatrixx;

        /// <summary>void glNormal3f(GLfloat nx, GLfloat ny, GLfloat nz);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLfloat, GLfloat, void> glNormal3f;

        /// <summary>void glNormal3x(GLfixed nx, GLfixed ny, GLfixed nz);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfixed, GLfixed, GLfixed, void> glNormal3x;

        /// <summary>void glNormalPointer(GLenum type, GLsizei stride, void* pointer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<NormalPointerType, GLsizei, void*, void> glNormalPointer;

        /// <summary>void glOrthof(GLfloat l, GLfloat r, GLfloat b, GLfloat t, GLfloat n, GLfloat f);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, void> glOrthof;

        /// <summary>void glOrthox(GLfixed l, GLfixed r, GLfixed b, GLfixed t, GLfixed n, GLfixed f);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfixed, GLfixed, GLfixed, GLfixed, GLfixed, GLfixed, void> glOrthox;

        /// <summary>void glPixelStorei(GLenum pname, GLint param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PixelStoreParameter, GLint, void> glPixelStorei;

        /// <summary>void glPointParameterf(GLenum pname, GLfloat param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PointParameterNameARB, GLfloat, void> glPointParameterf;

        /// <summary>void glPointParameterfv(GLenum pname, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PointParameterNameARB, GLfloat*, void> glPointParameterfv;

        /// <summary>void glPointParameterx(GLenum pname, GLfixed param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PointParameterNameARB, GLfixed, void> glPointParameterx;

        /// <summary>void glPointParameterxv(GLenum pname, GLfixed* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PointParameterNameARB, GLfixed*, void> glPointParameterxv;

        /// <summary>void glPointSize(GLfloat size);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, void> glPointSize;

        /// <summary>void glPointSizex(GLfixed size);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfixed, void> glPointSizex;

        /// <summary>void glPolygonOffset(GLfloat factor, GLfloat units);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLfloat, void> glPolygonOffset;

        /// <summary>void glPolygonOffsetx(GLfixed factor, GLfixed units);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfixed, GLfixed, void> glPolygonOffsetx;

        /// <summary>void glPopMatrix();</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void> glPopMatrix;

        /// <summary>void glPushMatrix();</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void> glPushMatrix;

        /// <summary>void glReadPixels(GLint x, GLint y, GLsizei width, GLsizei height, GLenum format, GLenum type, void* pixels);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLint, GLsizei, GLsizei, PixelFormat, PixelType, void*, void> glReadPixels;

        /// <summary>void glRotatef(GLfloat angle, GLfloat x, GLfloat y, GLfloat z);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLfloat, GLfloat, GLfloat, void> glRotatef;

        /// <summary>void glRotatex(GLfixed angle, GLfixed x, GLfixed y, GLfixed z);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfixed, GLfixed, GLfixed, GLfixed, void> glRotatex;

        /// <summary>void glSampleCoverage(GLfloat value, GLboolean invert);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLboolean, void> glSampleCoverage;

        /// <summary>void glSampleCoveragex(GLclampx value, GLboolean invert);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLclampx, GLboolean, void> glSampleCoveragex;

        /// <summary>void glScalef(GLfloat x, GLfloat y, GLfloat z);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLfloat, GLfloat, void> glScalef;

        /// <summary>void glScalex(GLfixed x, GLfixed y, GLfixed z);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfixed, GLfixed, GLfixed, void> glScalex;

        /// <summary>void glScissor(GLint x, GLint y, GLsizei width, GLsizei height);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLint, GLsizei, GLsizei, void> glScissor;

        /// <summary>void glShadeModel(GLenum mode);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ShadingModel, void> glShadeModel;

        /// <summary>void glStencilFunc(GLenum func, GLint ref, GLuint mask);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<StencilFunction, GLint, GLuint, void> glStencilFunc;

        /// <summary>void glStencilMask(GLuint mask);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, void> glStencilMask;

        /// <summary>void glStencilOp(GLenum fail, GLenum zfail, GLenum zpass);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<StencilOp, StencilOp, StencilOp, void> glStencilOp;

        /// <summary>void glTexCoordPointer(GLint size, GLenum type, GLsizei stride, void* pointer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, TexCoordPointerType, GLsizei, void*, void> glTexCoordPointer;

        /// <summary>void glTexEnvf(GLenum target, GLenum pname, GLfloat param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureEnvTarget, TextureEnvParameter, GLfloat, void> glTexEnvf;

        /// <summary>void glTexEnvfv(GLenum target, GLenum pname, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureEnvTarget, TextureEnvParameter, GLfloat*, void> glTexEnvfv;

        /// <summary>void glTexEnvi(GLenum target, GLenum pname, GLint param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureEnvTarget, TextureEnvParameter, GLint, void> glTexEnvi;

        /// <summary>void glTexEnviv(GLenum target, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureEnvTarget, TextureEnvParameter, GLint*, void> glTexEnviv;

        /// <summary>void glTexEnvx(GLenum target, GLenum pname, GLfixed param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureEnvTarget, TextureEnvParameter, GLfixed, void> glTexEnvx;

        /// <summary>void glTexEnvxv(GLenum target, GLenum pname, GLfixed* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureEnvTarget, TextureEnvParameter, GLfixed*, void> glTexEnvxv;

        /// <summary>void glTexImage2D(GLenum target, GLint level, GLint internalformat, GLsizei width, GLsizei height, GLint border, GLenum format, GLenum type, void* pixels);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLint, InternalFormat, GLsizei, GLsizei, GLint, PixelFormat, PixelType, void*, void> glTexImage2D;

        /// <summary>void glTexParameterf(GLenum target, GLenum pname, GLfloat param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, TextureParameterName, GLfloat, void> glTexParameterf;

        /// <summary>void glTexParameterfv(GLenum target, GLenum pname, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, TextureParameterName, GLfloat*, void> glTexParameterfv;

        /// <summary>void glTexParameteri(GLenum target, GLenum pname, GLint param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, TextureParameterName, GLint, void> glTexParameteri;

        /// <summary>void glTexParameteriv(GLenum target, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, TextureParameterName, GLint*, void> glTexParameteriv;

        /// <summary>void glTexParameterx(GLenum target, GLenum pname, GLfixed param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GetTextureParameter, GLfixed, void> glTexParameterx;

        /// <summary>void glTexParameterxv(GLenum target, GLenum pname, GLfixed* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GetTextureParameter, GLfixed*, void> glTexParameterxv;

        /// <summary>void glTexSubImage2D(GLenum target, GLint level, GLint xoffset, GLint yoffset, GLsizei width, GLsizei height, GLenum format, GLenum type, void* pixels);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLint, GLint, GLint, GLsizei, GLsizei, PixelFormat, PixelType, void*, void> glTexSubImage2D;

        /// <summary>void glTranslatef(GLfloat x, GLfloat y, GLfloat z);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLfloat, GLfloat, void> glTranslatef;

        /// <summary>void glTranslatex(GLfixed x, GLfixed y, GLfixed z);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfixed, GLfixed, GLfixed, void> glTranslatex;

        /// <summary>void glVertexPointer(GLint size, GLenum type, GLsizei stride, void* pointer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, VertexPointerType, GLsizei, void*, void> glVertexPointer;

        /// <summary>void glViewport(GLint x, GLint y, GLsizei width, GLsizei height);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLint, GLsizei, GLsizei, void> glViewport;
    }
}
#endif