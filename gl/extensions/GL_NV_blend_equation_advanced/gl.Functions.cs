#if GL_NV_blend_equation_advanced

public partial class gl { 
    public partial class Functions { 
        public static unsafe delegate* unmanaged[Cdecl]<void> glBlendBarrierNV;
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, GLint, void> glBlendParameteriNV;
    }
}

#endif