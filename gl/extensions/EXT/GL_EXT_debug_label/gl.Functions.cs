#if (GL_EXT_debug_label && (GL_API || GLCORE_API || GLES2_API))
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetObjectLabelEXT(GLenum type, GLuint object, GLsizei bufSize, GLsizei* length, GLchar* label);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, GLuint, GLsizei, GLsizei*, GLchar*, void> glGetObjectLabelEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glLabelObjectEXT(GLenum type, GLuint object, GLsizei length, GLchar* label);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, GLuint, GLsizei, GLchar*, void> glLabelObjectEXT;
#endif
    }
}
#endif