#if GL_ARB_compute_variable_group_size

public partial class gl { 
    public partial class Functions { 

        /// <summary>void glDispatchComputeGroupSizeARB(GLuint num_groups_x, GLuint num_groups_y, GLuint num_groups_z, GLuint group_size_x, GLuint group_size_y, GLuint group_size_z);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint, GLuint, GLuint, GLuint, GLuint, void> glDispatchComputeGroupSizeARB;
    }
}

#endif