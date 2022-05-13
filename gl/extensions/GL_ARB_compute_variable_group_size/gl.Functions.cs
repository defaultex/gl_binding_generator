#if GL_ARB_compute_variable_group_size

public partial class gl { 
    public partial class Functions { 
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint, GLuint, GLuint, GLuint, GLuint, void> glDispatchComputeGroupSizeARB;
    }
}

#endif