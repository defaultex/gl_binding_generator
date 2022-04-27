#if (GL_NV_bindless_multi_draw_indirect_count && (GL_API || GLCORE_API))
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glMultiDrawArraysIndirectBindlessCountNV(GLenum mode, const void* indirect, GLsizei drawCount, GLsizei maxDrawCount, GLsizei stride, GLint vertexBufferCount)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, void*, GLsizei, GLsizei, GLsizei, GLint, void> glMultiDrawArraysIndirectBindlessCountNV;

        /// <summary>void glMultiDrawElementsIndirectBindlessCountNV(GLenum mode, GLenum type, const void* indirect, GLsizei drawCount, GLsizei maxDrawCount, GLsizei stride, GLint vertexBufferCount)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, DrawElementsType, void*, GLsizei, GLsizei, GLsizei, GLint, void> glMultiDrawElementsIndirectBindlessCountNV;
    }
}
#endif