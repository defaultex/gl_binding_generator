#if (GL_ARB_robustness && (GL_API || GLCORE_API))
public partial class gl { 
    public partial class Functions { 
        /// <summary>GLenum glGetGraphicsResetStatusARB()</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum> glGetGraphicsResetStatusARB;

        /// <summary>void glGetnColorTableARB(GLenum target, GLenum format, GLenum type, GLsizei bufSize, void* table)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ColorTableTarget, PixelFormat, PixelType, GLsizei, void*, void> glGetnColorTableARB;

        /// <summary>void glGetnCompressedTexImageARB(GLenum target, GLint lod, GLsizei bufSize, void* img)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLint, GLsizei, void*, void> glGetnCompressedTexImageARB;

        /// <summary>void glGetnConvolutionFilterARB(GLenum target, GLenum format, GLenum type, GLsizei bufSize, void* image)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ConvolutionTarget, PixelFormat, PixelType, GLsizei, void*, void> glGetnConvolutionFilterARB;

        /// <summary>void glGetnHistogramARB(GLenum target, GLboolean reset, GLenum format, GLenum type, GLsizei bufSize, void* values)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<HistogramTargetEXT, GLboolean, PixelFormat, PixelType, GLsizei, void*, void> glGetnHistogramARB;

        /// <summary>void glGetnMapdvARB(GLenum target, GLenum query, GLsizei bufSize, GLdouble* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MapTarget, MapQuery, GLsizei, GLdouble*, void> glGetnMapdvARB;

        /// <summary>void glGetnMapfvARB(GLenum target, GLenum query, GLsizei bufSize, GLfloat* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MapTarget, MapQuery, GLsizei, GLfloat*, void> glGetnMapfvARB;

        /// <summary>void glGetnMapivARB(GLenum target, GLenum query, GLsizei bufSize, GLint* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MapTarget, MapQuery, GLsizei, GLint*, void> glGetnMapivARB;

        /// <summary>void glGetnMinmaxARB(GLenum target, GLboolean reset, GLenum format, GLenum type, GLsizei bufSize, void* values)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MinmaxTargetEXT, GLboolean, PixelFormat, PixelType, GLsizei, void*, void> glGetnMinmaxARB;

        /// <summary>void glGetnPixelMapfvARB(GLenum map, GLsizei bufSize, GLfloat* values)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PixelMap, GLsizei, GLfloat*, void> glGetnPixelMapfvARB;

        /// <summary>void glGetnPixelMapuivARB(GLenum map, GLsizei bufSize, GLuint* values)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PixelMap, GLsizei, GLuint*, void> glGetnPixelMapuivARB;

        /// <summary>void glGetnPixelMapusvARB(GLenum map, GLsizei bufSize, GLushort* values)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PixelMap, GLsizei, GLushort*, void> glGetnPixelMapusvARB;

        /// <summary>void glGetnPolygonStippleARB(GLsizei bufSize, GLubyte* pattern)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLubyte*, void> glGetnPolygonStippleARB;

        /// <summary>void glGetnSeparableFilterARB(GLenum target, GLenum format, GLenum type, GLsizei rowBufSize, void* row, GLsizei columnBufSize, void* column, void* span)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<SeparableTargetEXT, PixelFormat, PixelType, GLsizei, void*, GLsizei, void*, void*, void> glGetnSeparableFilterARB;

        /// <summary>void glGetnTexImageARB(GLenum target, GLint level, GLenum format, GLenum type, GLsizei bufSize, void* img)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLint, PixelFormat, PixelType, GLsizei, void*, void> glGetnTexImageARB;

        /// <summary>void glGetnUniformdvARB(GLuint program, GLint location, GLsizei bufSize, GLdouble* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLdouble*, void> glGetnUniformdvARB;

        /// <summary>void glGetnUniformfvARB(GLuint program, GLint location, GLsizei bufSize, GLfloat* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLfloat*, void> glGetnUniformfvARB;

        /// <summary>void glGetnUniformivARB(GLuint program, GLint location, GLsizei bufSize, GLint* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLint*, void> glGetnUniformivARB;

        /// <summary>void glGetnUniformuivARB(GLuint program, GLint location, GLsizei bufSize, GLuint* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLuint*, void> glGetnUniformuivARB;

        /// <summary>void glReadnPixelsARB(GLint x, GLint y, GLsizei width, GLsizei height, GLenum format, GLenum type, GLsizei bufSize, void* data)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLint, GLsizei, GLsizei, PixelFormat, PixelType, GLsizei, void*, void> glReadnPixelsARB;
    }
}
#endif