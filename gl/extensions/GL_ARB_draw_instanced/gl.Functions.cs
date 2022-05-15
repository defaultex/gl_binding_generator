#if GL_ARB_draw_instanced

public partial class gl { 
    public partial class Functions { 

        /// <summary>void glDrawArraysInstancedARB(GLenum mode, GLint first, GLsizei count, GLsizei primcount);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, GLint, GLsizei, GLsizei, void> glDrawArraysInstancedARB;

        /// <summary>void glDrawElementsInstancedARB(GLenum mode, GLsizei count, GLenum type, void* indices, GLsizei primcount);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, GLsizei, ElementType, void*, GLsizei, void> glDrawElementsInstancedARB;
    }
}

#endif