#if (GL_ARB_cl_event && (GL_API || GLCORE_API))
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>GLsync glCreateSyncFromCLeventARB(struct _cl_context* context, struct _cl_event* event, GLbitfield flags);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<cl_context*, cl_event*, GLbitfield, sync> glCreateSyncFromCLeventARB;
#endif
    }
}
#endif