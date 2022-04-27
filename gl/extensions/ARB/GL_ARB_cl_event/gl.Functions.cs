#if (GL_ARB_cl_event && (GL_API || GLCORE_API))
public partial class gl { 
    public partial class Functions { 
        /// <summary>GLsync glCreateSyncFromCLeventARB(struct _cl_context* context, struct _cl_event* event, GLbitfield flags)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<struct_cl_context*, struct_cl_event*, GLbitfield, GLsync> glCreateSyncFromCLeventARB;
    }
}
#endif