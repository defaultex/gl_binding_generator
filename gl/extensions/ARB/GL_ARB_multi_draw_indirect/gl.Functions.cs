#if (GL_ARB_multi_draw_indirect && (GL_API || GLCORE_API))
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glMultiDrawArraysIndirect(GLenum mode, void* indirect, GLsizei drawcount, GLsizei stride);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, void*, GLsizei, GLsizei, void> glMultiDrawArraysIndirect;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glMultiDrawElementsIndirect(GLenum mode, GLenum type, void* indirect, GLsizei drawcount, GLsizei stride);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, DrawElementsType, void*, GLsizei, GLsizei, void> glMultiDrawElementsIndirect;
#endif
    }
}
#endif