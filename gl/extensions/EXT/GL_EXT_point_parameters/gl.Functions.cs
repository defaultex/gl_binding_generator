#if (GL_EXT_point_parameters && !gl)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glPointParameterfEXT(GLenum pname, GLfloat param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PointParameterNameARB, GLfloat, void> glPointParameterfEXT;

        /// <summary>void glPointParameterfvEXT(GLenum pname, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PointParameterNameARB, GLfloat*, void> glPointParameterfvEXT;
    }
}
#endif