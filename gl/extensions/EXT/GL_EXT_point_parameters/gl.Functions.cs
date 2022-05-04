#if (GL_EXT_point_parameters && GL_API)
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glPointParameterfEXT(GLenum pname, GLfloat param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PointParameterNameARB, GLfloat, void> glPointParameterfEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glPointParameterfvEXT(GLenum pname, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PointParameterNameARB, GLfloat*, void> glPointParameterfvEXT;
#endif
    }
}
#endif