#if GL_ARB_cl_event

public partial class gl { 
    public partial class Functions { 
        public static unsafe delegate* unmanaged[Cdecl]<cl_context*, cl_event*, GLbitfield, GLsync> glCreateSyncFromCLeventARB;
    }
}

#endif