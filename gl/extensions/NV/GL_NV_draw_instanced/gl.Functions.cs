#if (GL_NV_draw_instanced && !gles2)
public partial class gles2 { 
    public partial class Functions { 
        /// <summary>void glDrawArraysInstancedNV(GLenum mode, GLint first, GLsizei count, GLsizei primcount);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, GLint, GLsizei, GLsizei, void> glDrawArraysInstancedNV;

        /// <summary>void glDrawElementsInstancedNV(GLenum mode, GLsizei count, GLenum type, void* indices, GLsizei primcount);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, GLsizei, PrimitiveType, void*, GLsizei, void> glDrawElementsInstancedNV;
    }
}
#endif