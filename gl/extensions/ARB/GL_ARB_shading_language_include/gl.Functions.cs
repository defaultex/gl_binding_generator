#if (GL_ARB_shading_language_include && (GL_API || GLCORE_API))
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glCompileShaderIncludeARB(GLuint shader, GLsizei count, GLchar** path, GLint* length);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<shader, GLsizei, GLchar**, GLint*, void> glCompileShaderIncludeARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glDeleteNamedStringARB(GLint namelen, GLchar* name);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLchar*, void> glDeleteNamedStringARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetNamedStringARB(GLint namelen, GLchar* name, GLsizei bufSize, GLint* stringlen, GLchar* string);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLchar*, GLsizei, GLint*, GLchar*, void> glGetNamedStringARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetNamedStringivARB(GLint namelen, GLchar* name, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLchar*, GLenum, GLint*, void> glGetNamedStringivARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>GLboolean glIsNamedStringARB(GLint namelen, GLchar* name);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLchar*, GLboolean> glIsNamedStringARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glNamedStringARB(GLenum type, GLint namelen, GLchar* name, GLint stringlen, GLchar* string);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, GLint, GLchar*, GLint, GLchar*, void> glNamedStringARB;
#endif
    }
}
#endif