#if (GL_EXT_multi_draw_indirect && !gles2)
public partial class gles2 { 
    public partial class Functions { 
        /// <summary>void glMultiDrawArraysIndirectEXT(GLenum mode, void* indirect, GLsizei drawcount, GLsizei stride);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, void*, GLsizei, GLsizei, void> glMultiDrawArraysIndirectEXT;

        /// <summary>void glMultiDrawElementsIndirectEXT(GLenum mode, GLenum type, void* indirect, GLsizei drawcount, GLsizei stride);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, DrawElementsType, void*, GLsizei, GLsizei, void> glMultiDrawElementsIndirectEXT;
    }
}
#endif