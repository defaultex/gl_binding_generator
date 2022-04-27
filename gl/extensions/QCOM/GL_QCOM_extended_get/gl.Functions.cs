#if (GL_QCOM_extended_get && (GLES1_API || GLES2_API))
public partial class gles1 { 
    public partial class Functions { 
        /// <summary>void glExtGetBufferPointervQCOM(GLenum target, void** params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, void**, void> glExtGetBufferPointervQCOM;

        /// <summary>void glExtGetBuffersQCOM(GLuint* buffers, GLint maxBuffers, GLint* numBuffers)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLbuffer*, GLint, GLint*, void> glExtGetBuffersQCOM;

        /// <summary>void glExtGetFramebuffersQCOM(GLuint* framebuffers, GLint maxFramebuffers, GLint* numFramebuffers)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLframebuffer*, GLint, GLint*, void> glExtGetFramebuffersQCOM;

        /// <summary>void glExtGetRenderbuffersQCOM(GLuint* renderbuffers, GLint maxRenderbuffers, GLint* numRenderbuffers)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLrenderbuffer*, GLint, GLint*, void> glExtGetRenderbuffersQCOM;

        /// <summary>void glExtGetTexLevelParameterivQCOM(GLuint texture, GLenum face, GLint level, GLenum pname, GLint* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLtexture, GLenum, GLint, GLenum, GLint*, void> glExtGetTexLevelParameterivQCOM;

        /// <summary>void glExtGetTexSubImageQCOM(GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GLenum format, GLenum type, void* texels)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, GLint, GLint, GLint, GLint, GLsizei, GLsizei, GLsizei, PixelFormat, PixelType, void*, void> glExtGetTexSubImageQCOM;

        /// <summary>void glExtGetTexturesQCOM(GLuint* textures, GLint maxTextures, GLint* numTextures)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLtexture*, GLint, GLint*, void> glExtGetTexturesQCOM;

        /// <summary>void glExtTexObjectStateOverrideiQCOM(GLenum target, GLenum pname, GLint param)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, GLenum, GLint, void> glExtTexObjectStateOverrideiQCOM;
    }
}
#endif