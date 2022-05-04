#if (GL_ARB_matrix_palette && GL_API)
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glCurrentPaletteMatrixARB(GLint index);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, void> glCurrentPaletteMatrixARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMatrixIndexPointerARB(GLint size, GLenum type, GLsizei stride, void* pointer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, MatrixIndexPointerTypeARB, GLsizei, void*, void> glMatrixIndexPointerARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMatrixIndexubvARB(GLint size, GLubyte* indices);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLubyte*, void> glMatrixIndexubvARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMatrixIndexuivARB(GLint size, GLuint* indices);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLuint*, void> glMatrixIndexuivARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMatrixIndexusvARB(GLint size, GLushort* indices);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLushort*, void> glMatrixIndexusvARB;
#endif
    }
}
#endif