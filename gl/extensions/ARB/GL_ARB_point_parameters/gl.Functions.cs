#if (GL_ARB_point_parameters && !gl)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glPointParameterfARB(GLenum pname, GLfloat param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PointParameterNameARB, GLfloat, void> glPointParameterfARB;

        /// <summary>void glPointParameterfvARB(GLenum pname, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PointParameterNameARB, GLfloat*, void> glPointParameterfvARB;
    }
}
#endif