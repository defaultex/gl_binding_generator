#if (GL_NV_bindless_multi_draw_indirect_count && (GL_API || GLCORE_API))
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMultiDrawArraysIndirectBindlessCountNV(GLenum mode, void* indirect, GLsizei drawCount, GLsizei maxDrawCount, GLsizei stride, GLint vertexBufferCount);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, void*, GLsizei, GLsizei, GLsizei, GLint, void> glMultiDrawArraysIndirectBindlessCountNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMultiDrawElementsIndirectBindlessCountNV(GLenum mode, GLenum type, void* indirect, GLsizei drawCount, GLsizei maxDrawCount, GLsizei stride, GLint vertexBufferCount);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, DrawElementsType, void*, GLsizei, GLsizei, GLsizei, GLint, void> glMultiDrawElementsIndirectBindlessCountNV;
#endif
    }
}
#endif