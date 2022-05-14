#if GL_NV_bindless_multi_draw_indirect

public partial class gl { 
    public partial class Functions { 
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, void*, GLsizei, GLsizei, GLint, void> glMultiDrawArraysIndirectBindlessNV;
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, ElementType, void*, GLsizei, GLsizei, GLint, void> glMultiDrawElementsIndirectBindlessNV;
    }
}

#endif