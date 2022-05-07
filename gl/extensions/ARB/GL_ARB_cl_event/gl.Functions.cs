#if (GL_ARB_cl_event && (!gl || !glcore))
public partial class gl { 
    public partial class Functions { 
        /// <summary>GLsync glCreateSyncFromCLeventARB(struct _cl_context* context, struct _cl_event* event, GLbitfield flags);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<cl_context*, cl_event*, GLbitfield, GLsync> glCreateSyncFromCLeventARB;
    }
}
#endif