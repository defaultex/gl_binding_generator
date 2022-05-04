#if (GL_ARB_robustness && (GL_API || GLCORE_API))
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>GLenum glGetGraphicsResetStatusARB();</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GraphicsResetStatus> glGetGraphicsResetStatusARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetnColorTableARB(GLenum target, GLenum format, GLenum type, GLsizei bufSize, void* table);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ColorTableTarget, PixelFormat, PixelType, GLsizei, void*, void> glGetnColorTableARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetnCompressedTexImageARB(GLenum target, GLint lod, GLsizei bufSize, void* img);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLint, GLsizei, void*, void> glGetnCompressedTexImageARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetnConvolutionFilterARB(GLenum target, GLenum format, GLenum type, GLsizei bufSize, void* image);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ConvolutionTarget, PixelFormat, PixelType, GLsizei, void*, void> glGetnConvolutionFilterARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetnHistogramARB(GLenum target, GLboolean reset, GLenum format, GLenum type, GLsizei bufSize, void* values);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<HistogramTargetEXT, GLboolean, PixelFormat, PixelType, GLsizei, void*, void> glGetnHistogramARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetnMapdvARB(GLenum target, GLenum query, GLsizei bufSize, GLdouble* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MapTarget, MapQuery, GLsizei, GLdouble*, void> glGetnMapdvARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetnMapfvARB(GLenum target, GLenum query, GLsizei bufSize, GLfloat* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MapTarget, MapQuery, GLsizei, GLfloat*, void> glGetnMapfvARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetnMapivARB(GLenum target, GLenum query, GLsizei bufSize, GLint* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MapTarget, MapQuery, GLsizei, GLint*, void> glGetnMapivARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetnMinmaxARB(GLenum target, GLboolean reset, GLenum format, GLenum type, GLsizei bufSize, void* values);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MinmaxTargetEXT, GLboolean, PixelFormat, PixelType, GLsizei, void*, void> glGetnMinmaxARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetnPixelMapfvARB(GLenum map, GLsizei bufSize, GLfloat* values);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PixelMap, GLsizei, GLfloat*, void> glGetnPixelMapfvARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetnPixelMapuivARB(GLenum map, GLsizei bufSize, GLuint* values);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PixelMap, GLsizei, GLuint*, void> glGetnPixelMapuivARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetnPixelMapusvARB(GLenum map, GLsizei bufSize, GLushort* values);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PixelMap, GLsizei, GLushort*, void> glGetnPixelMapusvARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetnPolygonStippleARB(GLsizei bufSize, GLubyte* pattern);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLubyte*, void> glGetnPolygonStippleARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetnSeparableFilterARB(GLenum target, GLenum format, GLenum type, GLsizei rowBufSize, void* row, GLsizei columnBufSize, void* column, void* span);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<SeparableTargetEXT, PixelFormat, PixelType, GLsizei, void*, GLsizei, void*, void*, void> glGetnSeparableFilterARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetnTexImageARB(GLenum target, GLint level, GLenum format, GLenum type, GLsizei bufSize, void* img);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLint, PixelFormat, PixelType, GLsizei, void*, void> glGetnTexImageARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetnUniformdvARB(GLuint program, GLint location, GLsizei bufSize, GLdouble* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLsizei, GLdouble*, void> glGetnUniformdvARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetnUniformfvARB(GLuint program, GLint location, GLsizei bufSize, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLsizei, GLfloat*, void> glGetnUniformfvARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetnUniformivARB(GLuint program, GLint location, GLsizei bufSize, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLsizei, GLint*, void> glGetnUniformivARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetnUniformuivARB(GLuint program, GLint location, GLsizei bufSize, GLuint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLsizei, GLuint*, void> glGetnUniformuivARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glReadnPixelsARB(GLint x, GLint y, GLsizei width, GLsizei height, GLenum format, GLenum type, GLsizei bufSize, void* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLint, GLsizei, GLsizei, PixelFormat, PixelType, GLsizei, void*, void> glReadnPixelsARB;
#endif
    }
}
#endif