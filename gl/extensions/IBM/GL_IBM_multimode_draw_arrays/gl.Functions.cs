#if (GL_IBM_multimode_draw_arrays && GL_API)
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMultiModeDrawArraysIBM(GLenum* mode, GLint* first, GLsizei* count, GLsizei primcount, GLint modestride);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType*, GLint*, GLsizei*, GLsizei, GLint, void> glMultiModeDrawArraysIBM;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMultiModeDrawElementsIBM(GLenum* mode, GLsizei* count, GLenum type, void** indices, GLsizei primcount, GLint modestride);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType*, GLsizei*, DrawElementsType, void**, GLsizei, GLint, void> glMultiModeDrawElementsIBM;
#endif
    }
}
#endif