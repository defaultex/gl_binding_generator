#if (GL_EXT_cull_vertex && GL_API)
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glCullParameterdvEXT(GLenum pname, GLdouble* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<CullParameterEXT, GLdouble*, void> glCullParameterdvEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glCullParameterfvEXT(GLenum pname, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<CullParameterEXT, GLfloat*, void> glCullParameterfvEXT;
#endif
    }
}
#endif