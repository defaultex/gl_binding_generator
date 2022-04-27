#if (GL_EXT_multi_draw_arrays && (GL_API || GLES1_API || GLES2_API))
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glMultiDrawArraysEXT(GLenum mode, const GLint* first, const GLsizei* count, GLsizei primcount)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, GLint*, GLsizei*, GLsizei, void> glMultiDrawArraysEXT;

        /// <summary>void glMultiDrawElementsEXT(GLenum mode, const GLsizei* count, GLenum type, const void*const* indices, GLsizei primcount)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, GLsizei*, DrawElementsType, void**, GLsizei, void> glMultiDrawElementsEXT;
    }
}
#endif