#if GL_NV_conditional_render

public partial class gl { 
    public partial class Functions { 
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, ConditionalRenderMode, void> glBeginConditionalRenderNV;
        public static unsafe delegate* unmanaged[Cdecl]<void> glEndConditionalRenderNV;
    }
}

#endif