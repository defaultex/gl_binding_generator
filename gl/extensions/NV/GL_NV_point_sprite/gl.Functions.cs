#if (GL_NV_point_sprite && GL_API)
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glPointParameteriNV(GLenum pname, GLint param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PointParameterNameARB, GLint, void> glPointParameteriNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glPointParameterivNV(GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PointParameterNameARB, GLint*, void> glPointParameterivNV;
#endif
    }
}
#endif