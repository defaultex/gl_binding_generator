#if (GL_NV_mesh_shader && (!gl || !glcore || !gles2))
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glDrawMeshTasksIndirectNV(GLintptr indirect);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLintptr, void> glDrawMeshTasksIndirectNV;

        /// <summary>void glDrawMeshTasksNV(GLuint first, GLuint count);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint, void> glDrawMeshTasksNV;

        /// <summary>void glMultiDrawMeshTasksIndirectCountNV(GLintptr indirect, GLintptr drawcount, GLsizei maxdrawcount, GLsizei stride);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLintptr, GLintptr, GLsizei, GLsizei, void> glMultiDrawMeshTasksIndirectCountNV;

        /// <summary>void glMultiDrawMeshTasksIndirectNV(GLintptr indirect, GLsizei drawcount, GLsizei stride);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLintptr, GLsizei, GLsizei, void> glMultiDrawMeshTasksIndirectNV;
    }
}
#endif