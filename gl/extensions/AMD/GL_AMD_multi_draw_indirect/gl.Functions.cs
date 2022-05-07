#if (GL_AMD_multi_draw_indirect && !gl)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glMultiDrawArraysIndirectAMD(GLenum mode, void* indirect, GLsizei primcount, GLsizei stride);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, void*, GLsizei, GLsizei, void> glMultiDrawArraysIndirectAMD;

        /// <summary>void glMultiDrawElementsIndirectAMD(GLenum mode, GLenum type, void* indirect, GLsizei primcount, GLsizei stride);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, DrawElementsType, void*, GLsizei, GLsizei, void> glMultiDrawElementsIndirectAMD;
    }
}
#endif