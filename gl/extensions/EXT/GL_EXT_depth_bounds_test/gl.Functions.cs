#if (GL_EXT_depth_bounds_test && GL_API)
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glDepthBoundsEXT(GLclampd zmin, GLclampd zmax);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLclampd, GLclampd, void> glDepthBoundsEXT;
#endif
    }
}
#endif