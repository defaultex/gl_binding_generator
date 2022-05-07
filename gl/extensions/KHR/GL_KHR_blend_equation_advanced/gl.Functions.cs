#if (GL_KHR_blend_equation_advanced && (!gl || !glcore || !gles2))
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glBlendBarrierKHR();</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void> glBlendBarrierKHR;
    }
}
#endif