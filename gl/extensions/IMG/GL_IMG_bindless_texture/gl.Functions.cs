#if (GL_IMG_bindless_texture && !gles2)
public partial class gles2 { 
    public partial class Functions { 
        /// <summary>GLuint64 glGetTextureHandleIMG(GLuint texture);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLtexture, GLuint64> glGetTextureHandleIMG;

        /// <summary>GLuint64 glGetTextureSamplerHandleIMG(GLuint texture, GLuint sampler);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLtexture, GLsampler, GLuint64> glGetTextureSamplerHandleIMG;

        /// <summary>void glProgramUniformHandleui64IMG(GLuint program, GLint location, GLuint64 value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLuint64, void> glProgramUniformHandleui64IMG;

        /// <summary>void glProgramUniformHandleui64vIMG(GLuint program, GLint location, GLsizei count, GLuint64* values);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLuint64*, void> glProgramUniformHandleui64vIMG;

        /// <summary>void glUniformHandleui64IMG(GLint location, GLuint64 value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLuint64, void> glUniformHandleui64IMG;

        /// <summary>void glUniformHandleui64vIMG(GLint location, GLsizei count, GLuint64* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLuint64*, void> glUniformHandleui64vIMG;
    }
}
#endif