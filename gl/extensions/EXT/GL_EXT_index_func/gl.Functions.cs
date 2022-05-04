#if (GL_EXT_index_func && GL_API)
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glIndexFuncEXT(GLenum func, GLclampf ref);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<IndexFunctionEXT, GLclampf, void> glIndexFuncEXT;
#endif
    }
}
#endif