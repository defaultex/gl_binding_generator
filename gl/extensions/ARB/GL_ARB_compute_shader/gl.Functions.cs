#if (GL_ARB_compute_shader && (!gl || !glcore))
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glDispatchCompute(GLuint num_groups_x, GLuint num_groups_y, GLuint num_groups_z);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint, GLuint, void> glDispatchCompute;

        /// <summary>void glDispatchComputeIndirect(GLintptr indirect);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLintptr, void> glDispatchComputeIndirect;
    }
}
#endif