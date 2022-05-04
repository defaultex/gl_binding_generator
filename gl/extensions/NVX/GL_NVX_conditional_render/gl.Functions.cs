#if (GL_NVX_conditional_render && GL_API)
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glBeginConditionalRenderNVX(GLuint id);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, void> glBeginConditionalRenderNVX;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glEndConditionalRenderNVX();</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void> glEndConditionalRenderNVX;
#endif
    }
}
#endif