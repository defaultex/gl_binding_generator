#if (GL_MESA_resize_buffers && !gl)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glResizeBuffersMESA();</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void> glResizeBuffersMESA;
    }
}
#endif