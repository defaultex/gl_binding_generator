#if (GL_ARB_transpose_matrix && GL_API)
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glLoadTransposeMatrixdARB(GLdouble* m);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLdouble*, void> glLoadTransposeMatrixdARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glLoadTransposeMatrixfARB(GLfloat* m);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat*, void> glLoadTransposeMatrixfARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMultTransposeMatrixdARB(GLdouble* m);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLdouble*, void> glMultTransposeMatrixdARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMultTransposeMatrixfARB(GLfloat* m);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat*, void> glMultTransposeMatrixfARB;
#endif
    }
}
#endif