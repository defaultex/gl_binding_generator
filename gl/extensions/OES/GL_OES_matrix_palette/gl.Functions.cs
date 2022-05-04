#if (GL_OES_matrix_palette && GLES1_API)
public partial class gles1 { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glCurrentPaletteMatrixOES(GLuint matrixpaletteindex);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, void> glCurrentPaletteMatrixOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glLoadPaletteFromModelViewMatrixOES();</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void> glLoadPaletteFromModelViewMatrixOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMatrixIndexPointerOES(GLint size, GLenum type, GLsizei stride, void* pointer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, MatrixIndexPointerTypeARB, GLsizei, void*, void> glMatrixIndexPointerOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glWeightPointerOES(GLint size, GLenum type, GLsizei stride, void* pointer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLenum, GLsizei, void*, void> glWeightPointerOES;
#endif
    }
}
#endif