#if (GL_ARB_multi_draw_indirect && (!gl || !glcore))
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glMultiDrawArraysIndirect(GLenum mode, void* indirect, GLsizei drawcount, GLsizei stride);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, void*, GLsizei, GLsizei, void> glMultiDrawArraysIndirect;

        /// <summary>void glMultiDrawElementsIndirect(GLenum mode, GLenum type, void* indirect, GLsizei drawcount, GLsizei stride);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, DrawElementsType, void*, GLsizei, GLsizei, void> glMultiDrawElementsIndirect;
    }
}
#endif