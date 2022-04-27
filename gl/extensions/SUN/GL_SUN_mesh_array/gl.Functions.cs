#if (GL_SUN_mesh_array && GL_API)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glDrawMeshArraysSUN(GLenum mode, GLint first, GLsizei count, GLsizei width)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, GLint, GLsizei, GLsizei, void> glDrawMeshArraysSUN;
    }
}
#endif