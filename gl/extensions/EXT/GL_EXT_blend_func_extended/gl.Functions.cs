#if (GL_EXT_blend_func_extended && GLES2_API)
public partial class gles2 { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glBindFragDataLocationEXT(GLuint program, GLuint color, GLchar* name);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLuint, GLchar*, void> glBindFragDataLocationEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glBindFragDataLocationIndexedEXT(GLuint program, GLuint colorNumber, GLuint index, GLchar* name);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLuint, GLuint, GLchar*, void> glBindFragDataLocationIndexedEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>GLint glGetFragDataIndexEXT(GLuint program, GLchar* name);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLchar*, GLint> glGetFragDataIndexEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>GLint glGetProgramResourceLocationIndexEXT(GLuint program, GLenum programInterface, GLchar* name);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, ProgramInterface, GLchar*, GLint> glGetProgramResourceLocationIndexEXT;
#endif
    }
}
#endif