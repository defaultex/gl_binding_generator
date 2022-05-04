#if (GL_QCOM_extended_get && (GLES1_API || GLES2_API))
public partial class gles1 { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glExtGetBufferPointervQCOM(GLenum target, void** params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, void**, void> glExtGetBufferPointervQCOM;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glExtGetBuffersQCOM(GLuint* buffers, GLint maxBuffers, GLint* numBuffers);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<buffer*, GLint, GLint*, void> glExtGetBuffersQCOM;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glExtGetFramebuffersQCOM(GLuint* framebuffers, GLint maxFramebuffers, GLint* numFramebuffers);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<framebuffer*, GLint, GLint*, void> glExtGetFramebuffersQCOM;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glExtGetRenderbuffersQCOM(GLuint* renderbuffers, GLint maxRenderbuffers, GLint* numRenderbuffers);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<renderbuffer*, GLint, GLint*, void> glExtGetRenderbuffersQCOM;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glExtGetTexLevelParameterivQCOM(GLuint texture, GLenum face, GLint level, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<texture, GLenum, GLint, GLenum, GLint*, void> glExtGetTexLevelParameterivQCOM;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glExtGetTexSubImageQCOM(GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GLenum format, GLenum type, void* texels);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, GLint, GLint, GLint, GLint, GLsizei, GLsizei, GLsizei, PixelFormat, PixelType, void*, void> glExtGetTexSubImageQCOM;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glExtGetTexturesQCOM(GLuint* textures, GLint maxTextures, GLint* numTextures);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<texture*, GLint, GLint*, void> glExtGetTexturesQCOM;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glExtTexObjectStateOverrideiQCOM(GLenum target, GLenum pname, GLint param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, GLenum, GLint, void> glExtTexObjectStateOverrideiQCOM;
#endif
    }
}
#endif