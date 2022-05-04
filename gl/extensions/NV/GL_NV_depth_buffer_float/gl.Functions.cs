#if (GL_NV_depth_buffer_float && (GL_API || GLCORE_API))
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glClearDepthdNV(GLdouble depth);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLdouble, void> glClearDepthdNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glDepthBoundsdNV(GLdouble zmin, GLdouble zmax);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLdouble, GLdouble, void> glDepthBoundsdNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glDepthRangedNV(GLdouble zNear, GLdouble zFar);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLdouble, GLdouble, void> glDepthRangedNV;
#endif
    }
}
#endif