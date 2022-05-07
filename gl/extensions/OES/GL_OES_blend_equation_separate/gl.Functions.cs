#if (GL_OES_blend_equation_separate && !gles1)
public partial class gles1 { 
    public partial class Functions { 
        /// <summary>void glBlendEquationSeparateOES(GLenum modeRGB, GLenum modeAlpha);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BlendEquationModeEXT, BlendEquationModeEXT, void> glBlendEquationSeparateOES;
    }
}
#endif