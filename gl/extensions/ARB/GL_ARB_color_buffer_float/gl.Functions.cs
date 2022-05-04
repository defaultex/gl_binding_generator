#if (GL_ARB_color_buffer_float && GL_API)
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glClampColorARB(GLenum target, GLenum clamp);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ClampColorTargetARB, ClampColorModeARB, void> glClampColorARB;
#endif
    }
}
#endif