#if (GL_ARB_draw_indirect && (!gl || !glcore))
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glDrawArraysIndirect(GLenum mode, void* indirect);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, void*, void> glDrawArraysIndirect;

        /// <summary>void glDrawElementsIndirect(GLenum mode, GLenum type, void* indirect);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, DrawElementsType, void*, void> glDrawElementsIndirect;
    }
}
#endif