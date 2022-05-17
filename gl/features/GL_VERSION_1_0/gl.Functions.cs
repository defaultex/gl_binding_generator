public partial class gl { 
    public partial class Functions { 

        /// <summary>void glBlendFunc(GLenum sfactor, GLenum dfactor);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BlendingFactor, BlendingFactor, void> glBlendFunc;

        /// <summary>void glClear(GLbitfield mask);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ClearBufferMask, void> glClear;

        /// <summary>void glClearColor(GLfloat red, GLfloat green, GLfloat blue, GLfloat alpha);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLfloat, GLfloat, GLfloat, void> glClearColor;

        /// <summary>void glClearDepth(GLdouble depth);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLdouble, void> glClearDepth;

        /// <summary>void glClearStencil(GLint s);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, void> glClearStencil;

        /// <summary>void glColorMask(GLboolean red, GLboolean green, GLboolean blue, GLboolean alpha);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLboolean, GLboolean, GLboolean, GLboolean, void> glColorMask;

        /// <summary>void glCullFace(GLenum mode);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FaceDirection, void> glCullFace;

        /// <summary>void glDepthFunc(GLenum func);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<CompareFunction, void> glDepthFunc;

        /// <summary>void glDepthMask(GLboolean flag);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLboolean, void> glDepthMask;

        /// <summary>void glDepthRange(GLdouble n, GLdouble f);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLdouble, GLdouble, void> glDepthRange;

        /// <summary>void glDisable(GLenum cap);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLCapability, void> glDisable;

        /// <summary>void glDrawBuffer(GLenum buf);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ColorBuffer, void> glDrawBuffer;

        /// <summary>void glEnable(GLenum cap);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLCapability, void> glEnable;

        /// <summary>void glFinish();</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void> glFinish;

        /// <summary>void glFlush();</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void> glFlush;

        /// <summary>void glFrontFace(GLenum mode);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<WindingOrder, void> glFrontFace;

        /// <summary>void glGetBooleanv(GLenum pname, GLboolean* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLParameter, GLboolean*, void> glGetBooleanv;

        /// <summary>void glGetDoublev(GLenum pname, GLdouble* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLParameter, GLdouble*, void> glGetDoublev;

        /// <summary>GLenum glGetError();</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLError> glGetError;

        /// <summary>void glGetFloatv(GLenum pname, GLfloat* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLParameter, GLfloat*, void> glGetFloatv;

        /// <summary>void glGetIntegerv(GLenum pname, GLint* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLParameter, GLint*, void> glGetIntegerv;

        /// <summary>GLubyte* glGetString(GLenum name);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLString, GLubyte*> glGetString;

        /// <summary>void glGetTexImage(GLenum target, GLint level, GLenum format, GLenum type, void* pixels);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLint, PixelFormat, PixelType, void*, void> glGetTexImage;

        /// <summary>void glGetTexLevelParameterfv(GLenum target, GLint level, GLenum pname, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLint, TextureParameter, GLfloat*, void> glGetTexLevelParameterfv;

        /// <summary>void glGetTexLevelParameteriv(GLenum target, GLint level, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLint, TextureParameter, GLint*, void> glGetTexLevelParameteriv;

        /// <summary>void glGetTexParameterfv(GLenum target, GLenum pname, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, TextureParameter, GLfloat*, void> glGetTexParameterfv;

        /// <summary>void glGetTexParameteriv(GLenum target, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, TextureParameter, GLint*, void> glGetTexParameteriv;

        /// <summary>void glHint(GLenum target, GLenum mode);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<HintTarget, HintMode, void> glHint;

        /// <summary>GLboolean glIsEnabled(GLenum cap);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLCapability, GLboolean> glIsEnabled;

        /// <summary>void glLineWidth(GLfloat width);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, void> glLineWidth;

        /// <summary>void glLogicOp(GLenum opcode);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<LogicOp, void> glLogicOp;

        /// <summary>void glPixelStoref(GLenum pname, GLfloat param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PixelStoreParameter, GLfloat, void> glPixelStoref;

        /// <summary>void glPixelStorei(GLenum pname, GLint param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PixelStoreParameter, GLint, void> glPixelStorei;

        /// <summary>void glPointSize(GLfloat size);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, void> glPointSize;

        /// <summary>void glPolygonMode(GLenum face, GLenum mode);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FaceDirection, PolygonMode, void> glPolygonMode;

        /// <summary>void glReadBuffer(GLenum src);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ColorBuffer, void> glReadBuffer;

        /// <summary>void glReadPixels(GLint x, GLint y, GLsizei width, GLsizei height, GLenum format, GLenum type, void* pixels);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLint, GLsizei, GLsizei, PixelFormat, PixelType, void*, void> glReadPixels;

        /// <summary>void glScissor(GLint x, GLint y, GLsizei width, GLsizei height);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLint, GLsizei, GLsizei, void> glScissor;

        /// <summary>void glStencilFunc(GLenum func, GLint ref, GLuint mask);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<StencilFunction, GLint, GLuint, void> glStencilFunc;

        /// <summary>void glStencilMask(GLuint mask);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, void> glStencilMask;

        /// <summary>void glStencilOp(GLenum fail, GLenum zfail, GLenum zpass);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<StencilOp, StencilOp, StencilOp, void> glStencilOp;

        /// <summary>void glTexImage1D(GLenum target, GLint level, GLint internalformat, GLsizei width, GLint border, GLenum format, GLenum type, void* pixels);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLint, InternalFormat, GLsizei, GLint, PixelFormat, PixelType, void*, void> glTexImage1D;

        /// <summary>void glTexImage2D(GLenum target, GLint level, GLint internalformat, GLsizei width, GLsizei height, GLint border, GLenum format, GLenum type, void* pixels);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLint, InternalFormat, GLsizei, GLsizei, GLint, PixelFormat, PixelType, void*, void> glTexImage2D;

        /// <summary>void glTexParameterf(GLenum target, GLenum pname, GLfloat param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, TextureParameter, GLfloat, void> glTexParameterf;

        /// <summary>void glTexParameterfv(GLenum target, GLenum pname, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, TextureParameter, GLfloat*, void> glTexParameterfv;

        /// <summary>void glTexParameteri(GLenum target, GLenum pname, GLint param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, TextureParameter, GLint, void> glTexParameteri;

        /// <summary>void glTexParameteriv(GLenum target, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, TextureParameter, GLint*, void> glTexParameteriv;

        /// <summary>void glViewport(GLint x, GLint y, GLsizei width, GLsizei height);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLint, GLsizei, GLsizei, void> glViewport;
    }
}
