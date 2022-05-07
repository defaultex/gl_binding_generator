#if (GL_EXT_blend_equation_separate && !gl)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glBlendEquationSeparateEXT(GLenum modeRGB, GLenum modeAlpha);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BlendEquationModeEXT, BlendEquationModeEXT, void> glBlendEquationSeparateEXT;
    }
}
#endif