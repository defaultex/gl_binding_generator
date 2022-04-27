#if (GL_ARB_draw_indirect && (GL_API || GLCORE_API))
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glDrawArraysIndirect(GLenum mode, const void* indirect)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, void*, void> glDrawArraysIndirect;

        /// <summary>void glDrawElementsIndirect(GLenum mode, GLenum type, const void* indirect)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, DrawElementsType, void*, void> glDrawElementsIndirect;
    }
}
#endif