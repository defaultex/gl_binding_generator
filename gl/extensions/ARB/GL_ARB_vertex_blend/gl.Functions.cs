#if (GL_ARB_vertex_blend && GL_API)
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexBlendARB(GLint count);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, void> glVertexBlendARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glWeightbvARB(GLint size, GLbyte* weights);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLbyte*, void> glWeightbvARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glWeightdvARB(GLint size, GLdouble* weights);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLdouble*, void> glWeightdvARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glWeightfvARB(GLint size, GLfloat* weights);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLfloat*, void> glWeightfvARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glWeightivARB(GLint size, GLint* weights);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLint*, void> glWeightivARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glWeightPointerARB(GLint size, GLenum type, GLsizei stride, void* pointer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, WeightPointerTypeARB, GLsizei, void*, void> glWeightPointerARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glWeightsvARB(GLint size, GLshort* weights);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLshort*, void> glWeightsvARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glWeightubvARB(GLint size, GLubyte* weights);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLubyte*, void> glWeightubvARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glWeightuivARB(GLint size, GLuint* weights);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLuint*, void> glWeightuivARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glWeightusvARB(GLint size, GLushort* weights);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLushort*, void> glWeightusvARB;
#endif
    }
}
#endif