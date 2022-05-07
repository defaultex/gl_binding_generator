#if (GL_NVX_conditional_render && !gl)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glBeginConditionalRenderNVX(GLuint id);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, void> glBeginConditionalRenderNVX;

        /// <summary>void glEndConditionalRenderNVX();</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void> glEndConditionalRenderNVX;
    }
}
#endif