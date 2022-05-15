#if GL_ARB_indirect_parameters

public partial class gl { 
    public partial class Functions { 

        /// <summary>void glMultiDrawArraysIndirectCountARB(GLenum mode, void* indirect, GLintptr drawcount, GLsizei maxdrawcount, GLsizei stride);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, void*, GLintptr, GLsizei, GLsizei, void> glMultiDrawArraysIndirectCountARB;

        /// <summary>void glMultiDrawElementsIndirectCountARB(GLenum mode, GLenum type, void* indirect, GLintptr drawcount, GLsizei maxdrawcount, GLsizei stride);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, ElementType, void*, GLintptr, GLsizei, GLsizei, void> glMultiDrawElementsIndirectCountARB;
    }
}

#endif