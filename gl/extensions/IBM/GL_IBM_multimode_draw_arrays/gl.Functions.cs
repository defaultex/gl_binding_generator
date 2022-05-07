#if (GL_IBM_multimode_draw_arrays && !gl)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glMultiModeDrawArraysIBM(GLenum* mode, GLint* first, GLsizei* count, GLsizei primcount, GLint modestride);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType*, GLint*, GLsizei*, GLsizei, GLint, void> glMultiModeDrawArraysIBM;

        /// <summary>void glMultiModeDrawElementsIBM(GLenum* mode, GLsizei* count, GLenum type, void** indices, GLsizei primcount, GLint modestride);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType*, GLsizei*, DrawElementsType, void**, GLsizei, GLint, void> glMultiModeDrawElementsIBM;
    }
}
#endif