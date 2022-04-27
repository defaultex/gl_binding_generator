#if (GL_EXT_cull_vertex && GL_API)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glCullParameterdvEXT(GLenum pname, GLdouble* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<CullParameterEXT, GLdouble*, void> glCullParameterdvEXT;

        /// <summary>void glCullParameterfvEXT(GLenum pname, GLfloat* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<CullParameterEXT, GLfloat*, void> glCullParameterfvEXT;
    }
}
#endif