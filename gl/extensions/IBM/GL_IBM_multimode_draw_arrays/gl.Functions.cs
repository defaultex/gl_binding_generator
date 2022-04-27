#if (GL_IBM_multimode_draw_arrays && GL_API)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glMultiModeDrawArraysIBM(const GLenum* mode, const GLint* first, const GLsizei* count, GLsizei primcount, GLint modestride)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType*, GLint*, GLsizei*, GLsizei, GLint, void> glMultiModeDrawArraysIBM;

        /// <summary>void glMultiModeDrawElementsIBM(const GLenum* mode, const GLsizei* count, GLenum type, const void*const* indices, GLsizei primcount, GLint modestride)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType*, GLsizei*, DrawElementsType, void**, GLsizei, GLint, void> glMultiModeDrawElementsIBM;
    }
}
#endif