#if GL_NV_mesh_shader

public partial class gl { 
    public partial class Functions { 
        public static unsafe delegate* unmanaged[Cdecl]<GLintptr, void> glDrawMeshTasksIndirectNV;
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint, void> glDrawMeshTasksNV;
        public static unsafe delegate* unmanaged[Cdecl]<GLintptr, GLintptr, GLsizei, GLsizei, void> glMultiDrawMeshTasksIndirectCountNV;
        public static unsafe delegate* unmanaged[Cdecl]<GLintptr, GLsizei, GLsizei, void> glMultiDrawMeshTasksIndirectNV;
    }
}

#endif