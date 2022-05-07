#if (GL_EXT_multi_draw_arrays && (!gl || !gles1 || !gles2))
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glMultiDrawArraysEXT(GLenum mode, GLint* first, GLsizei* count, GLsizei primcount);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, GLint*, GLsizei*, GLsizei, void> glMultiDrawArraysEXT;

        /// <summary>void glMultiDrawElementsEXT(GLenum mode, GLsizei* count, GLenum type, void** indices, GLsizei primcount);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, GLsizei*, DrawElementsType, void**, GLsizei, void> glMultiDrawElementsEXT;
    }
}
#endif