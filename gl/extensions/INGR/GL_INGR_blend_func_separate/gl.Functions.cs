#if (GL_INGR_blend_func_separate && GL_API)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glBlendFuncSeparateINGR(GLenum sfactorRGB, GLenum dfactorRGB, GLenum sfactorAlpha, GLenum dfactorAlpha)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BlendingFactor, BlendingFactor, BlendingFactor, BlendingFactor, void> glBlendFuncSeparateINGR;
    }
}
#endif