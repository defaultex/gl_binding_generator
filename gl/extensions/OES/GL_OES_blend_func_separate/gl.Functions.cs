#if (GL_OES_blend_func_separate && !gles1)
public partial class gles1 { 
    public partial class Functions { 
        /// <summary>void glBlendFuncSeparateOES(GLenum srcRGB, GLenum dstRGB, GLenum srcAlpha, GLenum dstAlpha);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BlendingFactor, BlendingFactor, BlendingFactor, BlendingFactor, void> glBlendFuncSeparateOES;
    }
}
#endif