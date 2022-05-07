#if (GL_NV_conditional_render && (!gl || !glcore || !gles2))
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glBeginConditionalRenderNV(GLuint id, GLenum mode);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, ConditionalRenderMode, void> glBeginConditionalRenderNV;

        /// <summary>void glEndConditionalRenderNV();</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void> glEndConditionalRenderNV;
    }
}
#endif