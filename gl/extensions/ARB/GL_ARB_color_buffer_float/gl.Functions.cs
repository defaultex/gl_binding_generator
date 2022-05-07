#if (GL_ARB_color_buffer_float && !gl)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glClampColorARB(GLenum target, GLenum clamp);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ClampColorTargetARB, ClampColorModeARB, void> glClampColorARB;
    }
}
#endif