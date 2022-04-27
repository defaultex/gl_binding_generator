#if (GL_NV_mesh_shader && (GL_API || GLCORE_API || GLES2_API))
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glDrawMeshTasksNV(GLuint first, GLuint count)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint, void> glDrawMeshTasksNV;

        /// <summary>void glDrawMeshTasksIndirectNV(GLintptr indirect)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLintptr, void> glDrawMeshTasksIndirectNV;

        /// <summary>void glMultiDrawMeshTasksIndirectNV(GLintptr indirect, GLsizei drawcount, GLsizei stride)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLintptr, GLsizei, GLsizei, void> glMultiDrawMeshTasksIndirectNV;

        /// <summary>void glMultiDrawMeshTasksIndirectCountNV(GLintptr indirect, GLintptr drawcount, GLsizei maxdrawcount, GLsizei stride)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLintptr, GLintptr, GLsizei, GLsizei, void> glMultiDrawMeshTasksIndirectCountNV;
    }
}
#endif