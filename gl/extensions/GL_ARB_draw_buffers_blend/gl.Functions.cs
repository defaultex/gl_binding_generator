#if GL_ARB_draw_buffers_blend

public partial class gl { 
    public partial class Functions { 
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, BlendEquationMode, void> glBlendEquationiARB;
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, BlendEquationMode, BlendEquationMode, void> glBlendEquationSeparateiARB;
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, BlendingFactor, BlendingFactor, void> glBlendFunciARB;
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, BlendingFactor, BlendingFactor, BlendingFactor, BlendingFactor, void> glBlendFuncSeparateiARB;
    }
}

#endif