#if (GL_AMD_multi_draw_indirect && GL_API)
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMultiDrawArraysIndirectAMD(GLenum mode, void* indirect, GLsizei primcount, GLsizei stride);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, void*, GLsizei, GLsizei, void> glMultiDrawArraysIndirectAMD;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMultiDrawElementsIndirectAMD(GLenum mode, GLenum type, void* indirect, GLsizei primcount, GLsizei stride);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, DrawElementsType, void*, GLsizei, GLsizei, void> glMultiDrawElementsIndirectAMD;
#endif
    }
}
#endif