#if (GL_SUN_triangle_list && GL_API)
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glReplacementCodePointerSUN(GLenum type, GLsizei stride, void** pointer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ReplacementCodeTypeSUN, GLsizei, void**, void> glReplacementCodePointerSUN;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glReplacementCodeubSUN(GLubyte code);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLubyte, void> glReplacementCodeubSUN;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glReplacementCodeubvSUN(GLubyte* code);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLubyte*, void> glReplacementCodeubvSUN;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glReplacementCodeuiSUN(GLuint code);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, void> glReplacementCodeuiSUN;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glReplacementCodeuivSUN(GLuint* code);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint*, void> glReplacementCodeuivSUN;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glReplacementCodeusSUN(GLushort code);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLushort, void> glReplacementCodeusSUN;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glReplacementCodeusvSUN(GLushort* code);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLushort*, void> glReplacementCodeusvSUN;
#endif
    }
}
#endif