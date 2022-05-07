#if (GL_EXT_blend_minmax && (!gl || !gles1 || !gles2))
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glBlendEquationEXT(GLenum mode);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BlendEquationModeEXT, void> glBlendEquationEXT;
    }
}
#endif