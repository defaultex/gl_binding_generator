#if (GL_EXT_provoking_vertex && !gl)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glProvokingVertexEXT(GLenum mode);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<VertexProvokingMode, void> glProvokingVertexEXT;
    }
}
#endif