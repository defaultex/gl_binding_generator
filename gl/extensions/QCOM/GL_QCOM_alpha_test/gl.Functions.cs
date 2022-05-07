#if (GL_QCOM_alpha_test && !gles2)
public partial class gles2 { 
    public partial class Functions { 
        /// <summary>void glAlphaFuncQCOM(GLenum func, GLclampf ref);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, GLclampf, void> glAlphaFuncQCOM;
    }
}
#endif