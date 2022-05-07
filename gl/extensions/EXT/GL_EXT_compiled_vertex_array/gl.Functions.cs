#if (GL_EXT_compiled_vertex_array && !gl)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glLockArraysEXT(GLint first, GLsizei count);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, void> glLockArraysEXT;

        /// <summary>void glUnlockArraysEXT();</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void> glUnlockArraysEXT;
    }
}
#endif