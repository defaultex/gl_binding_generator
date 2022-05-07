#if (GL_EXT_draw_instanced && (!gl || !glcore || !gles2))
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glDrawArraysInstancedEXT(GLenum mode, GLint start, GLsizei count, GLsizei primcount);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, GLint, GLsizei, GLsizei, void> glDrawArraysInstancedEXT;

        /// <summary>void glDrawElementsInstancedEXT(GLenum mode, GLsizei count, GLenum type, void* indices, GLsizei primcount);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, GLsizei, DrawElementsType, void*, GLsizei, void> glDrawElementsInstancedEXT;
    }
}
#endif