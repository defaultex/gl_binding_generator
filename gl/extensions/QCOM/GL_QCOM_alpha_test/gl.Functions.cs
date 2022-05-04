#if (GL_QCOM_alpha_test && GLES2_API)
public partial class gles2 { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glAlphaFuncQCOM(GLenum func, GLclampf ref);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, GLclampf, void> glAlphaFuncQCOM;
#endif
    }
}
#endif