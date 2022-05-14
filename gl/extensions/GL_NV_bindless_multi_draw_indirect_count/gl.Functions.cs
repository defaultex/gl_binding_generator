#if GL_NV_bindless_multi_draw_indirect_count

public partial class gl { 
    public partial class Functions { 
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, void*, GLsizei, GLsizei, GLsizei, GLint, void> glMultiDrawArraysIndirectBindlessCountNV;
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, ElementType, void*, GLsizei, GLsizei, GLsizei, GLint, void> glMultiDrawElementsIndirectBindlessCountNV;
    }
}

#endif