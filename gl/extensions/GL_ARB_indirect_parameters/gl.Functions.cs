#if GL_ARB_indirect_parameters

public partial class gl { 
    public partial class Functions { 
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, void*, GLintptr, GLsizei, GLsizei, void> glMultiDrawArraysIndirectCountARB;
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, ElementType, void*, GLintptr, GLsizei, GLsizei, void> glMultiDrawElementsIndirectCountARB;
    }
}

#endif