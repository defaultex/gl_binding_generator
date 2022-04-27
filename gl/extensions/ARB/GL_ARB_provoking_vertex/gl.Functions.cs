#if (GL_ARB_provoking_vertex && (GL_API || GLCORE_API))
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glProvokingVertex(GLenum mode)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<VertexProvokingMode, void> glProvokingVertex;
    }
}
#endif