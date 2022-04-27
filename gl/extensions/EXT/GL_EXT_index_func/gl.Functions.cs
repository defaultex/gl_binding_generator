#if (GL_EXT_index_func && GL_API)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glIndexFuncEXT(GLenum func, GLclampf ref)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<IndexFunctionEXT, GLclampf, void> glIndexFuncEXT;
    }
}
#endif