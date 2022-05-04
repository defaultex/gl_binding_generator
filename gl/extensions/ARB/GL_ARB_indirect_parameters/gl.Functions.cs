#if (GL_ARB_indirect_parameters && (GL_API || GLCORE_API))
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMultiDrawArraysIndirectCountARB(GLenum mode, void* indirect, GLintptr drawcount, GLsizei maxdrawcount, GLsizei stride);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, void*, GLintptr, GLsizei, GLsizei, void> glMultiDrawArraysIndirectCountARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMultiDrawElementsIndirectCountARB(GLenum mode, GLenum type, void* indirect, GLintptr drawcount, GLsizei maxdrawcount, GLsizei stride);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, DrawElementsType, void*, GLintptr, GLsizei, GLsizei, void> glMultiDrawElementsIndirectCountARB;
#endif
    }
}
#endif