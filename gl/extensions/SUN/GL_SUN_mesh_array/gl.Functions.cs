#if (GL_SUN_mesh_array && GL_API)
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glDrawMeshArraysSUN(GLenum mode, GLint first, GLsizei count, GLsizei width);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, GLint, GLsizei, GLsizei, void> glDrawMeshArraysSUN;
#endif
    }
}
#endif