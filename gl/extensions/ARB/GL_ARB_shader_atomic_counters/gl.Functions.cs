#if (GL_ARB_shader_atomic_counters && (!gl || !glcore))
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glGetActiveAtomicCounterBufferiv(GLuint program, GLuint bufferIndex, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLuint, AtomicCounterBufferPName, GLint*, void> glGetActiveAtomicCounterBufferiv;
    }
}
#endif