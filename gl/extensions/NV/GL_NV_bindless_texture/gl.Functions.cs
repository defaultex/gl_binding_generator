#if (GL_NV_bindless_texture && (GL_API || GLCORE_API || GLES2_API))
public partial class gl { 
    public partial class Functions { 
        /// <summary>GLuint64 glGetImageHandleNV(GLuint texture, GLint level, GLboolean layered, GLint layer, GLenum format)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLtexture, GLint, GLboolean, GLint, PixelFormat, GLuint64> glGetImageHandleNV;

        /// <summary>GLuint64 glGetTextureHandleNV(GLuint texture)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLtexture, GLuint64> glGetTextureHandleNV;

        /// <summary>GLuint64 glGetTextureSamplerHandleNV(GLuint texture, GLuint sampler)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLtexture, GLsampler, GLuint64> glGetTextureSamplerHandleNV;

        /// <summary>GLboolean glIsImageHandleResidentNV(GLuint64 handle)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint64, GLboolean> glIsImageHandleResidentNV;

        /// <summary>GLboolean glIsTextureHandleResidentNV(GLuint64 handle)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint64, GLboolean> glIsTextureHandleResidentNV;

        /// <summary>void glMakeImageHandleNonResidentNV(GLuint64 handle)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint64, void> glMakeImageHandleNonResidentNV;

        /// <summary>void glMakeImageHandleResidentNV(GLuint64 handle, GLenum access)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint64, GLenum, void> glMakeImageHandleResidentNV;

        /// <summary>void glMakeTextureHandleNonResidentNV(GLuint64 handle)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint64, void> glMakeTextureHandleNonResidentNV;

        /// <summary>void glMakeTextureHandleResidentNV(GLuint64 handle)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint64, void> glMakeTextureHandleResidentNV;

        /// <summary>void glProgramUniformHandleui64NV(GLuint program, GLint location, GLuint64 value)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLuint64, void> glProgramUniformHandleui64NV;

        /// <summary>void glProgramUniformHandleui64vNV(GLuint program, GLint location, GLsizei count, const GLuint64* values)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLuint64*, void> glProgramUniformHandleui64vNV;

        /// <summary>void glUniformHandleui64NV(GLint location, GLuint64 value)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLuint64, void> glUniformHandleui64NV;

        /// <summary>void glUniformHandleui64vNV(GLint location, GLsizei count, const GLuint64* value)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLuint64*, void> glUniformHandleui64vNV;
    }
}
#endif