#if (GL_NV_depth_buffer_float && (!gl || !glcore))
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glClearDepthdNV(GLdouble depth);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLdouble, void> glClearDepthdNV;

        /// <summary>void glDepthBoundsdNV(GLdouble zmin, GLdouble zmax);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLdouble, GLdouble, void> glDepthBoundsdNV;

        /// <summary>void glDepthRangedNV(GLdouble zNear, GLdouble zFar);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLdouble, GLdouble, void> glDepthRangedNV;
    }
}
#endif