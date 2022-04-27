#if (GL_VERSION_ES_CM_1_0 && GLES1_API)
public partial class gles1 { 
    public partial class Functions { 
#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_3)

        /// <summary>void glActiveTexture(GLenum texture)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, void> glActiveTexture;

#endif

#if !GL_VERSION_1_0

        /// <summary>void glAlphaFunc(GLenum func, GLfloat ref)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<AlphaFunction, GLfloat, void> glAlphaFunc;

#endif

        /// <summary>void glAlphaFuncx(GLenum func, GLfixed ref)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<AlphaFunction, GLfixed, void> glAlphaFuncx;

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_5)

        /// <summary>void glBindBuffer(GLenum target, GLuint buffer)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BufferTargetARB, GLbuffer, void> glBindBuffer;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_1)

        /// <summary>void glBindTexture(GLenum target, GLuint texture)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLtexture, void> glBindTexture;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_0)

        /// <summary>void glBlendFunc(GLenum sfactor, GLenum dfactor)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BlendingFactor, BlendingFactor, void> glBlendFunc;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_5)

        /// <summary>void glBufferData(GLenum target, GLsizeiptr size, const void* data, GLenum usage)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BufferTargetARB, GLsizeiptr, void*, BufferUsageARB, void> glBufferData;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_5)

        /// <summary>void glBufferSubData(GLenum target, GLintptr offset, GLsizeiptr size, const void* data)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BufferTargetARB, GLintptr, GLsizeiptr, void*, void> glBufferSubData;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_0)

        /// <summary>void glClear(GLbitfield mask)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ClearBufferMask, void> glClear;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_0)

        /// <summary>void glClearColor(GLfloat red, GLfloat green, GLfloat blue, GLfloat alpha)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLfloat, GLfloat, GLfloat, void> glClearColor;

#endif

        /// <summary>void glClearColorx(GLfixed red, GLfixed green, GLfixed blue, GLfixed alpha)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfixed, GLfixed, GLfixed, GLfixed, void> glClearColorx;

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_4_1)

        /// <summary>void glClearDepthf(GLfloat d)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, void> glClearDepthf;

#endif

        /// <summary>void glClearDepthx(GLfixed depth)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfixed, void> glClearDepthx;

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_0)

        /// <summary>void glClearStencil(GLint s)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, void> glClearStencil;

#endif

#if !GL_VERSION_1_3

        /// <summary>void glClientActiveTexture(GLenum texture)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, void> glClientActiveTexture;

#endif

        /// <summary>void glClipPlanef(GLenum p, const GLfloat* eqn)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ClipPlaneName, GLfloat*, void> glClipPlanef;

        /// <summary>void glClipPlanex(GLenum plane, const GLfixed* equation)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ClipPlaneName, GLfixed*, void> glClipPlanex;

#if !GL_VERSION_1_0

        /// <summary>void glColor4f(GLfloat red, GLfloat green, GLfloat blue, GLfloat alpha)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLfloat, GLfloat, GLfloat, void> glColor4f;

#endif

#if !GL_VERSION_1_0

        /// <summary>void glColor4ub(GLubyte red, GLubyte green, GLubyte blue, GLubyte alpha)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLubyte, GLubyte, GLubyte, GLubyte, void> glColor4ub;

#endif

        /// <summary>void glColor4x(GLfixed red, GLfixed green, GLfixed blue, GLfixed alpha)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfixed, GLfixed, GLfixed, GLfixed, void> glColor4x;

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_0)

        /// <summary>void glColorMask(GLboolean red, GLboolean green, GLboolean blue, GLboolean alpha)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLboolean, GLboolean, GLboolean, GLboolean, void> glColorMask;

#endif

#if !GL_VERSION_1_1

        /// <summary>void glColorPointer(GLint size, GLenum type, GLsizei stride, const void* pointer)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, ColorPointerType, GLsizei, void*, void> glColorPointer;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_VERSION_1_3)

        /// <summary>void glCompressedTexImage2D(GLenum target, GLint level, GLenum internalformat, GLsizei width, GLsizei height, GLint border, GLsizei imageSize, const void* data)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLint, InternalFormat, GLsizei, GLsizei, GLint, GLsizei, void*, void> glCompressedTexImage2D;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_3)

        /// <summary>void glCompressedTexSubImage2D(GLenum target, GLint level, GLint xoffset, GLint yoffset, GLsizei width, GLsizei height, GLenum format, GLsizei imageSize, const void* data)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLint, GLint, GLint, GLsizei, GLsizei, InternalFormat, GLsizei, void*, void> glCompressedTexSubImage2D;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_VERSION_1_1)

        /// <summary>void glCopyTexImage2D(GLenum target, GLint level, GLenum internalformat, GLint x, GLint y, GLsizei width, GLsizei height, GLint border)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLint, InternalFormat, GLint, GLint, GLsizei, GLsizei, GLint, void> glCopyTexImage2D;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_VERSION_1_1)

        /// <summary>void glCopyTexSubImage2D(GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint x, GLint y, GLsizei width, GLsizei height)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLint, GLint, GLint, GLint, GLint, GLsizei, GLsizei, void> glCopyTexSubImage2D;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_0)

        /// <summary>void glCullFace(GLenum mode)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<CullFaceMode, void> glCullFace;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_VERSION_1_5)

        /// <summary>void glDeleteBuffers(GLsizei n, const GLuint* buffers)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLbuffer*, void> glDeleteBuffers;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_VERSION_1_1)

        /// <summary>void glDeleteTextures(GLsizei n, const GLuint* textures)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLtexture*, void> glDeleteTextures;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_0)

        /// <summary>void glDepthFunc(GLenum func)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<DepthFunction, void> glDepthFunc;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_0)

        /// <summary>void glDepthMask(GLboolean flag)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLboolean, void> glDepthMask;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_4_1)

        /// <summary>void glDepthRangef(GLfloat n, GLfloat f)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLfloat, void> glDepthRangef;

#endif

        /// <summary>void glDepthRangex(GLfixed n, GLfixed f)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfixed, GLfixed, void> glDepthRangex;

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_0)

        /// <summary>void glDisable(GLenum cap)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<EnableCap, void> glDisable;

#endif

#if !GL_VERSION_1_1

        /// <summary>void glDisableClientState(GLenum array)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<EnableCap, void> glDisableClientState;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_1)

        /// <summary>void glDrawArrays(GLenum mode, GLint first, GLsizei count)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, GLint, GLsizei, void> glDrawArrays;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_VERSION_1_1)

        /// <summary>void glDrawElements(GLenum mode, GLsizei count, GLenum type, const void* indices)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, GLsizei, DrawElementsType, void*, void> glDrawElements;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_0)

        /// <summary>void glEnable(GLenum cap)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<EnableCap, void> glEnable;

#endif

#if !GL_VERSION_1_1

        /// <summary>void glEnableClientState(GLenum array)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<EnableCap, void> glEnableClientState;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_0)

        /// <summary>void glFinish()</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void> glFinish;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_0)

        /// <summary>void glFlush()</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void> glFlush;

#endif

#if !GL_VERSION_1_0

        /// <summary>void glFogf(GLenum pname, GLfloat param)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FogParameter, GLfloat, void> glFogf;

#endif

#if !GL_VERSION_1_0

        /// <summary>void glFogfv(GLenum pname, const GLfloat* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FogParameter, GLfloat*, void> glFogfv;

#endif

        /// <summary>void glFogx(GLenum pname, GLfixed param)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FogPName, GLfixed, void> glFogx;

        /// <summary>void glFogxv(GLenum pname, const GLfixed* param)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FogPName, GLfixed*, void> glFogxv;

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_0)

        /// <summary>void glFrontFace(GLenum mode)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FrontFaceDirection, void> glFrontFace;

#endif

        /// <summary>void glFrustumf(GLfloat l, GLfloat r, GLfloat b, GLfloat t, GLfloat n, GLfloat f)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, void> glFrustumf;

        /// <summary>void glFrustumx(GLfixed l, GLfixed r, GLfixed b, GLfixed t, GLfixed n, GLfixed f)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfixed, GLfixed, GLfixed, GLfixed, GLfixed, GLfixed, void> glFrustumx;

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_5)

        /// <summary>void glGenBuffers(GLsizei n, GLuint* buffers)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLbuffer*, void> glGenBuffers;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_1)

        /// <summary>void glGenTextures(GLsizei n, GLuint* textures)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLtexture*, void> glGenTextures;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_0)

        /// <summary>void glGetBooleanv(GLenum pname, GLboolean* data)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GetPName, GLboolean*, void> glGetBooleanv;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_5)

        /// <summary>void glGetBufferParameteriv(GLenum target, GLenum pname, GLint* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BufferTargetARB, BufferPNameARB, GLint*, void> glGetBufferParameteriv;

#endif

        /// <summary>void glGetClipPlanef(GLenum plane, GLfloat* equation)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ClipPlaneName, GLfloat*, void> glGetClipPlanef;

        /// <summary>void glGetClipPlanex(GLenum plane, GLfixed* equation)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ClipPlaneName, GLfixed*, void> glGetClipPlanex;

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_0)

        /// <summary>GLenum glGetError()</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum> glGetError;

#endif

        /// <summary>void glGetFixedv(GLenum pname, GLfixed* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GetPName, GLfixed*, void> glGetFixedv;

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_0)

        /// <summary>void glGetFloatv(GLenum pname, GLfloat* data)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GetPName, GLfloat*, void> glGetFloatv;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_0)

        /// <summary>void glGetIntegerv(GLenum pname, GLint* data)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GetPName, GLint*, void> glGetIntegerv;

#endif

#if !GL_VERSION_1_0

        /// <summary>void glGetLightfv(GLenum light, GLenum pname, GLfloat* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<LightName, LightParameter, GLfloat*, void> glGetLightfv;

#endif

        /// <summary>void glGetLightxv(GLenum light, GLenum pname, GLfixed* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<LightName, LightParameter, GLfixed*, void> glGetLightxv;

#if !GL_VERSION_1_0

        /// <summary>void glGetMaterialfv(GLenum face, GLenum pname, GLfloat* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MaterialFace, MaterialParameter, GLfloat*, void> glGetMaterialfv;

#endif

        /// <summary>void glGetMaterialxv(GLenum face, GLenum pname, GLfixed* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MaterialFace, MaterialParameter, GLfixed*, void> glGetMaterialxv;

#if (!GL_ES_VERSION_3_2 && !GL_VERSION_1_1 && !GL_VERSION_4_3)

        /// <summary>void glGetPointerv(GLenum pname, void** params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GetPointervPName, void**, void> glGetPointerv;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_0)

        /// <summary>GLubyte* glGetString(GLenum name)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<StringName, GLubyte*> glGetString;

#endif

#if !GL_VERSION_1_0

        /// <summary>void glGetTexEnvfv(GLenum target, GLenum pname, GLfloat* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureEnvTarget, TextureEnvParameter, GLfloat*, void> glGetTexEnvfv;

#endif

#if !GL_VERSION_1_0

        /// <summary>void glGetTexEnviv(GLenum target, GLenum pname, GLint* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureEnvTarget, TextureEnvParameter, GLint*, void> glGetTexEnviv;

#endif

        /// <summary>void glGetTexEnvxv(GLenum target, GLenum pname, GLfixed* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureEnvTarget, TextureEnvParameter, GLfixed*, void> glGetTexEnvxv;

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_0)

        /// <summary>void glGetTexParameterfv(GLenum target, GLenum pname, GLfloat* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GetTextureParameter, GLfloat*, void> glGetTexParameterfv;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_0)

        /// <summary>void glGetTexParameteriv(GLenum target, GLenum pname, GLint* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GetTextureParameter, GLint*, void> glGetTexParameteriv;

#endif

        /// <summary>void glGetTexParameterxv(GLenum target, GLenum pname, GLfixed* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GetTextureParameter, GLfixed*, void> glGetTexParameterxv;

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_0)

        /// <summary>void glHint(GLenum target, GLenum mode)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<HintTarget, HintMode, void> glHint;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_VERSION_1_5)

        /// <summary>GLboolean glIsBuffer(GLuint buffer)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLbuffer, GLboolean> glIsBuffer;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_0)

        /// <summary>GLboolean glIsEnabled(GLenum cap)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<EnableCap, GLboolean> glIsEnabled;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_VERSION_1_1)

        /// <summary>GLboolean glIsTexture(GLuint texture)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLtexture, GLboolean> glIsTexture;

#endif

#if !GL_VERSION_1_0

        /// <summary>void glLightModelf(GLenum pname, GLfloat param)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<LightModelParameter, GLfloat, void> glLightModelf;

#endif

#if !GL_VERSION_1_0

        /// <summary>void glLightModelfv(GLenum pname, const GLfloat* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<LightModelParameter, GLfloat*, void> glLightModelfv;

#endif

        /// <summary>void glLightModelx(GLenum pname, GLfixed param)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<LightModelParameter, GLfixed, void> glLightModelx;

        /// <summary>void glLightModelxv(GLenum pname, const GLfixed* param)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<LightModelParameter, GLfixed*, void> glLightModelxv;

#if !GL_VERSION_1_0

        /// <summary>void glLightf(GLenum light, GLenum pname, GLfloat param)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<LightName, LightParameter, GLfloat, void> glLightf;

#endif

#if !GL_VERSION_1_0

        /// <summary>void glLightfv(GLenum light, GLenum pname, const GLfloat* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<LightName, LightParameter, GLfloat*, void> glLightfv;

#endif

        /// <summary>void glLightx(GLenum light, GLenum pname, GLfixed param)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<LightName, LightParameter, GLfixed, void> glLightx;

        /// <summary>void glLightxv(GLenum light, GLenum pname, const GLfixed* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<LightName, LightParameter, GLfixed*, void> glLightxv;

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_0)

        /// <summary>void glLineWidth(GLfloat width)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, void> glLineWidth;

#endif

        /// <summary>void glLineWidthx(GLfixed width)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfixed, void> glLineWidthx;

#if !GL_VERSION_1_0

        /// <summary>void glLoadIdentity()</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void> glLoadIdentity;

#endif

#if !GL_VERSION_1_0

        /// <summary>void glLoadMatrixf(const GLfloat* m)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat*, void> glLoadMatrixf;

#endif

        /// <summary>void glLoadMatrixx(const GLfixed* m)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfixed*, void> glLoadMatrixx;

#if !GL_VERSION_1_0

        /// <summary>void glLogicOp(GLenum opcode)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<LogicOp, void> glLogicOp;

#endif

#if !GL_VERSION_1_0

        /// <summary>void glMaterialf(GLenum face, GLenum pname, GLfloat param)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MaterialFace, MaterialParameter, GLfloat, void> glMaterialf;

#endif

#if !GL_VERSION_1_0

        /// <summary>void glMaterialfv(GLenum face, GLenum pname, const GLfloat* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MaterialFace, MaterialParameter, GLfloat*, void> glMaterialfv;

#endif

        /// <summary>void glMaterialx(GLenum face, GLenum pname, GLfixed param)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MaterialFace, MaterialParameter, GLfixed, void> glMaterialx;

        /// <summary>void glMaterialxv(GLenum face, GLenum pname, const GLfixed* param)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MaterialFace, MaterialParameter, GLfixed*, void> glMaterialxv;

#if !GL_VERSION_1_0

        /// <summary>void glMatrixMode(GLenum mode)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MatrixMode, void> glMatrixMode;

#endif

#if !GL_VERSION_1_0

        /// <summary>void glMultMatrixf(const GLfloat* m)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat*, void> glMultMatrixf;

#endif

        /// <summary>void glMultMatrixx(const GLfixed* m)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfixed*, void> glMultMatrixx;

#if !GL_VERSION_1_3

        /// <summary>void glMultiTexCoord4f(GLenum target, GLfloat s, GLfloat t, GLfloat r, GLfloat q)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLfloat, GLfloat, GLfloat, GLfloat, void> glMultiTexCoord4f;

#endif

        /// <summary>void glMultiTexCoord4x(GLenum texture, GLfixed s, GLfixed t, GLfixed r, GLfixed q)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLfixed, GLfixed, GLfixed, GLfixed, void> glMultiTexCoord4x;

#if !GL_VERSION_1_0

        /// <summary>void glNormal3f(GLfloat nx, GLfloat ny, GLfloat nz)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLfloat, GLfloat, void> glNormal3f;

#endif

        /// <summary>void glNormal3x(GLfixed nx, GLfixed ny, GLfixed nz)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfixed, GLfixed, GLfixed, void> glNormal3x;

#if !GL_VERSION_1_1

        /// <summary>void glNormalPointer(GLenum type, GLsizei stride, const void* pointer)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<NormalPointerType, GLsizei, void*, void> glNormalPointer;

#endif

        /// <summary>void glOrthof(GLfloat l, GLfloat r, GLfloat b, GLfloat t, GLfloat n, GLfloat f)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, void> glOrthof;

        /// <summary>void glOrthox(GLfixed l, GLfixed r, GLfixed b, GLfixed t, GLfixed n, GLfixed f)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfixed, GLfixed, GLfixed, GLfixed, GLfixed, GLfixed, void> glOrthox;

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_0)

        /// <summary>void glPixelStorei(GLenum pname, GLint param)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PixelStoreParameter, GLint, void> glPixelStorei;

#endif

#if !GL_VERSION_1_4

        /// <summary>void glPointParameterf(GLenum pname, GLfloat param)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PointParameterNameARB, GLfloat, void> glPointParameterf;

#endif

#if !GL_VERSION_1_4

        /// <summary>void glPointParameterfv(GLenum pname, const GLfloat* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PointParameterNameARB, GLfloat*, void> glPointParameterfv;

#endif

        /// <summary>void glPointParameterx(GLenum pname, GLfixed param)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PointParameterNameARB, GLfixed, void> glPointParameterx;

        /// <summary>void glPointParameterxv(GLenum pname, const GLfixed* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PointParameterNameARB, GLfixed*, void> glPointParameterxv;

#if !GL_VERSION_1_0

        /// <summary>void glPointSize(GLfloat size)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, void> glPointSize;

#endif

        /// <summary>void glPointSizex(GLfixed size)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfixed, void> glPointSizex;

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_1)

        /// <summary>void glPolygonOffset(GLfloat factor, GLfloat units)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLfloat, void> glPolygonOffset;

#endif

        /// <summary>void glPolygonOffsetx(GLfixed factor, GLfixed units)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfixed, GLfixed, void> glPolygonOffsetx;

#if !GL_VERSION_1_0

        /// <summary>void glPopMatrix()</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void> glPopMatrix;

#endif

#if !GL_VERSION_1_0

        /// <summary>void glPushMatrix()</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void> glPushMatrix;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_VERSION_1_0)

        /// <summary>void glReadPixels(GLint x, GLint y, GLsizei width, GLsizei height, GLenum format, GLenum type, void* pixels)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLint, GLsizei, GLsizei, PixelFormat, PixelType, void*, void> glReadPixels;

#endif

#if !GL_VERSION_1_0

        /// <summary>void glRotatef(GLfloat angle, GLfloat x, GLfloat y, GLfloat z)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLfloat, GLfloat, GLfloat, void> glRotatef;

#endif

        /// <summary>void glRotatex(GLfixed angle, GLfixed x, GLfixed y, GLfixed z)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfixed, GLfixed, GLfixed, GLfixed, void> glRotatex;

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_3)

        /// <summary>void glSampleCoverage(GLfloat value, GLboolean invert)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLboolean, void> glSampleCoverage;

#endif

        /// <summary>void glSampleCoveragex(GLclampx value, GLboolean invert)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLclampx, GLboolean, void> glSampleCoveragex;

#if !GL_VERSION_1_0

        /// <summary>void glScalef(GLfloat x, GLfloat y, GLfloat z)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLfloat, GLfloat, void> glScalef;

#endif

        /// <summary>void glScalex(GLfixed x, GLfixed y, GLfixed z)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfixed, GLfixed, GLfixed, void> glScalex;

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_0)

        /// <summary>void glScissor(GLint x, GLint y, GLsizei width, GLsizei height)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLint, GLsizei, GLsizei, void> glScissor;

#endif

#if !GL_VERSION_1_0

        /// <summary>void glShadeModel(GLenum mode)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ShadingModel, void> glShadeModel;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_0)

        /// <summary>void glStencilFunc(GLenum func, GLint ref, GLuint mask)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<StencilFunction, GLint, GLuint, void> glStencilFunc;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_0)

        /// <summary>void glStencilMask(GLuint mask)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, void> glStencilMask;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_0)

        /// <summary>void glStencilOp(GLenum fail, GLenum zfail, GLenum zpass)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<StencilOp, StencilOp, StencilOp, void> glStencilOp;

#endif

#if !GL_VERSION_1_1

        /// <summary>void glTexCoordPointer(GLint size, GLenum type, GLsizei stride, const void* pointer)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, TexCoordPointerType, GLsizei, void*, void> glTexCoordPointer;

#endif

#if !GL_VERSION_1_0

        /// <summary>void glTexEnvf(GLenum target, GLenum pname, GLfloat param)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureEnvTarget, TextureEnvParameter, GLfloat, void> glTexEnvf;

#endif

#if !GL_VERSION_1_0

        /// <summary>void glTexEnvfv(GLenum target, GLenum pname, const GLfloat* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureEnvTarget, TextureEnvParameter, GLfloat*, void> glTexEnvfv;

#endif

#if !GL_VERSION_1_0

        /// <summary>void glTexEnvi(GLenum target, GLenum pname, GLint param)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureEnvTarget, TextureEnvParameter, GLint, void> glTexEnvi;

#endif

#if !GL_VERSION_1_0

        /// <summary>void glTexEnviv(GLenum target, GLenum pname, const GLint* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureEnvTarget, TextureEnvParameter, GLint*, void> glTexEnviv;

#endif

        /// <summary>void glTexEnvx(GLenum target, GLenum pname, GLfixed param)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureEnvTarget, TextureEnvParameter, GLfixed, void> glTexEnvx;

        /// <summary>void glTexEnvxv(GLenum target, GLenum pname, const GLfixed* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureEnvTarget, TextureEnvParameter, GLfixed*, void> glTexEnvxv;

#if (!GL_ES_VERSION_2_0 && !GL_VERSION_1_0)

        /// <summary>void glTexImage2D(GLenum target, GLint level, GLint internalformat, GLsizei width, GLsizei height, GLint border, GLenum format, GLenum type, const void* pixels)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLint, InternalFormat, GLsizei, GLsizei, GLint, PixelFormat, PixelType, void*, void> glTexImage2D;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_0)

        /// <summary>void glTexParameterf(GLenum target, GLenum pname, GLfloat param)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, TextureParameterName, GLfloat, void> glTexParameterf;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_0)

        /// <summary>void glTexParameterfv(GLenum target, GLenum pname, const GLfloat* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, TextureParameterName, GLfloat*, void> glTexParameterfv;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_0)

        /// <summary>void glTexParameteri(GLenum target, GLenum pname, GLint param)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, TextureParameterName, GLint, void> glTexParameteri;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_0)

        /// <summary>void glTexParameteriv(GLenum target, GLenum pname, const GLint* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, TextureParameterName, GLint*, void> glTexParameteriv;

#endif

        /// <summary>void glTexParameterx(GLenum target, GLenum pname, GLfixed param)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GetTextureParameter, GLfixed, void> glTexParameterx;

        /// <summary>void glTexParameterxv(GLenum target, GLenum pname, const GLfixed* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GetTextureParameter, GLfixed*, void> glTexParameterxv;

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_1)

        /// <summary>void glTexSubImage2D(GLenum target, GLint level, GLint xoffset, GLint yoffset, GLsizei width, GLsizei height, GLenum format, GLenum type, const void* pixels)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLint, GLint, GLint, GLsizei, GLsizei, PixelFormat, PixelType, void*, void> glTexSubImage2D;

#endif

#if !GL_VERSION_1_0

        /// <summary>void glTranslatef(GLfloat x, GLfloat y, GLfloat z)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLfloat, GLfloat, void> glTranslatef;

#endif

        /// <summary>void glTranslatex(GLfixed x, GLfixed y, GLfixed z)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfixed, GLfixed, GLfixed, void> glTranslatex;

#if !GL_VERSION_1_1

        /// <summary>void glVertexPointer(GLint size, GLenum type, GLsizei stride, const void* pointer)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, VertexPointerType, GLsizei, void*, void> glVertexPointer;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_0)

        /// <summary>void glViewport(GLint x, GLint y, GLsizei width, GLsizei height)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLint, GLsizei, GLsizei, void> glViewport;

#endif
    }
}
#endif