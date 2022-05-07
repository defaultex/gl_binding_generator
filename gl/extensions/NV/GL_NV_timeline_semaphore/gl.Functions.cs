#if (GL_NV_timeline_semaphore && (!gl || !gles2))
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glCreateSemaphoresNV(GLsizei n, GLuint* semaphores);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLuint*, void> glCreateSemaphoresNV;

        /// <summary>void glGetSemaphoreParameterivNV(GLuint semaphore, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, SemaphoreParameterName, GLint*, void> glGetSemaphoreParameterivNV;

        /// <summary>void glSemaphoreParameterivNV(GLuint semaphore, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, SemaphoreParameterName, GLint*, void> glSemaphoreParameterivNV;
    }
}
#endif