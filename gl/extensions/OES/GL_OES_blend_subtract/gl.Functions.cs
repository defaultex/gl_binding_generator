#if (GL_OES_blend_subtract && !gles1)
public partial class gles1 { 
    public partial class Functions { 
        /// <summary>void glBlendEquationOES(GLenum mode);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BlendEquationModeEXT, void> glBlendEquationOES;
    }
}
#endif