#if (GL_ARB_draw_instanced && (!gl || !glcore))
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glDrawArraysInstancedARB(GLenum mode, GLint first, GLsizei count, GLsizei primcount);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, GLint, GLsizei, GLsizei, void> glDrawArraysInstancedARB;

        /// <summary>void glDrawElementsInstancedARB(GLenum mode, GLsizei count, GLenum type, void* indices, GLsizei primcount);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, GLsizei, DrawElementsType, void*, GLsizei, void> glDrawElementsInstancedARB;
    }
}
#endif