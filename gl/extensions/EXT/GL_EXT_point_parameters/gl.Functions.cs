#if (GL_EXT_point_parameters && GL_API)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glPointParameterfEXT(GLenum pname, GLfloat param)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PointParameterNameARB, GLfloat, void> glPointParameterfEXT;

        /// <summary>void glPointParameterfvEXT(GLenum pname, const GLfloat* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PointParameterNameARB, GLfloat*, void> glPointParameterfvEXT;
    }
}
#endif