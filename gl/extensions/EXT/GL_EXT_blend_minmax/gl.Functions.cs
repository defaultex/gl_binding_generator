#if (GL_EXT_blend_minmax && (GL_API || GLES1_API || GLES2_API))
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glBlendEquationEXT(GLenum mode)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BlendEquationModeEXT, void> glBlendEquationEXT;
    }
}
#endif