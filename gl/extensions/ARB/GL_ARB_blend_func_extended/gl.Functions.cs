#if (GL_ARB_blend_func_extended && (GL_API || GLCORE_API))
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glBindFragDataLocationIndexed(GLuint program, GLuint colorNumber, GLuint index, GLchar* name);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLuint, GLuint, GLchar*, void> glBindFragDataLocationIndexed;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>GLint glGetFragDataIndex(GLuint program, GLchar* name);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLchar*, GLint> glGetFragDataIndex;
#endif
    }
}
#endif