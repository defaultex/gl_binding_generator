#if (GL_ARB_point_parameters && GL_API)
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glPointParameterfARB(GLenum pname, GLfloat param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PointParameterNameARB, GLfloat, void> glPointParameterfARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glPointParameterfvARB(GLenum pname, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PointParameterNameARB, GLfloat*, void> glPointParameterfvARB;
#endif
    }
}
#endif