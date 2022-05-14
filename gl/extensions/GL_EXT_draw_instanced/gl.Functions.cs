#if GL_EXT_draw_instanced

public partial class gl { 
    public partial class Functions { 
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, GLint, GLsizei, GLsizei, void> glDrawArraysInstancedEXT;
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, GLsizei, ElementType, void*, GLsizei, void> glDrawElementsInstancedEXT;
    }
}

#endif