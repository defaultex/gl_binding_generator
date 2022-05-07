#if (GL_SGIS_point_parameters && !gl)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glPointParameterfSGIS(GLenum pname, GLfloat param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PointParameterNameARB, GLfloat, void> glPointParameterfSGIS;

        /// <summary>void glPointParameterfvSGIS(GLenum pname, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PointParameterNameARB, GLfloat*, void> glPointParameterfvSGIS;
    }
}
#endif