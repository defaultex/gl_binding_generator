#if (GL_KHR_blend_equation_advanced && (GL_API || GLCORE_API || GLES2_API))
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glBlendBarrierKHR()</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void> glBlendBarrierKHR;
    }
}
#endif