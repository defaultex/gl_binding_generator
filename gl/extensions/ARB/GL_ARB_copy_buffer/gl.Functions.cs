#if (GL_ARB_copy_buffer && (GL_API || GLCORE_API))
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glCopyBufferSubData(GLenum readTarget, GLenum writeTarget, GLintptr readOffset, GLintptr writeOffset, GLsizeiptr size)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<CopyBufferSubDataTarget, CopyBufferSubDataTarget, GLintptr, GLintptr, GLsizeiptr, void> glCopyBufferSubData;
    }
}
#endif