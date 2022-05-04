#if (GL_IMG_bindless_texture && GLES2_API)
public partial class gles2 { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>GLuint64 glGetTextureHandleIMG(GLuint texture);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<texture, GLuint64> glGetTextureHandleIMG;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>GLuint64 glGetTextureSamplerHandleIMG(GLuint texture, GLuint sampler);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<texture, sampler, GLuint64> glGetTextureSamplerHandleIMG;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glProgramUniformHandleui64IMG(GLuint program, GLint location, GLuint64 value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLuint64, void> glProgramUniformHandleui64IMG;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glProgramUniformHandleui64vIMG(GLuint program, GLint location, GLsizei count, GLuint64* values);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLsizei, GLuint64*, void> glProgramUniformHandleui64vIMG;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glUniformHandleui64IMG(GLint location, GLuint64 value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLuint64, void> glUniformHandleui64IMG;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glUniformHandleui64vIMG(GLint location, GLsizei count, GLuint64* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLuint64*, void> glUniformHandleui64vIMG;
#endif
    }
}
#endif