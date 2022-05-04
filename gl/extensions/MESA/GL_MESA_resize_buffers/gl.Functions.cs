#if (GL_MESA_resize_buffers && GL_API)
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glResizeBuffersMESA();</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void> glResizeBuffersMESA;
#endif
    }
}
#endif