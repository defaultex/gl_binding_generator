#if (GL_NV_bindless_multi_draw_indirect && (!gl || !glcore))
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glMultiDrawArraysIndirectBindlessNV(GLenum mode, void* indirect, GLsizei drawCount, GLsizei stride, GLint vertexBufferCount);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, void*, GLsizei, GLsizei, GLint, void> glMultiDrawArraysIndirectBindlessNV;

        /// <summary>void glMultiDrawElementsIndirectBindlessNV(GLenum mode, GLenum type, void* indirect, GLsizei drawCount, GLsizei stride, GLint vertexBufferCount);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, DrawElementsType, void*, GLsizei, GLsizei, GLint, void> glMultiDrawElementsIndirectBindlessNV;
    }
}
#endif