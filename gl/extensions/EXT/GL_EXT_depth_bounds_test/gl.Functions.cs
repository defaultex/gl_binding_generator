#if (GL_EXT_depth_bounds_test && !gl)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glDepthBoundsEXT(GLclampd zmin, GLclampd zmax);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLclampd, GLclampd, void> glDepthBoundsEXT;
    }
}
#endif