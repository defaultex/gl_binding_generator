#if (GL_NV_point_sprite && !gl)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glPointParameteriNV(GLenum pname, GLint param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PointParameterNameARB, GLint, void> glPointParameteriNV;

        /// <summary>void glPointParameterivNV(GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PointParameterNameARB, GLint*, void> glPointParameterivNV;
    }
}
#endif