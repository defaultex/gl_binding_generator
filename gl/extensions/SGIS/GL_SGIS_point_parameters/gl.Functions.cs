#if (GL_SGIS_point_parameters && GL_API)
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glPointParameterfSGIS(GLenum pname, GLfloat param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PointParameterNameARB, GLfloat, void> glPointParameterfSGIS;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glPointParameterfvSGIS(GLenum pname, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PointParameterNameARB, GLfloat*, void> glPointParameterfvSGIS;
#endif
    }
}
#endif