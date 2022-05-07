#if (GL_NV_vertex_array_range && !gl)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glFlushVertexArrayRangeNV();</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void> glFlushVertexArrayRangeNV;

        /// <summary>void glVertexArrayRangeNV(GLsizei length, void* pointer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, void*, void> glVertexArrayRangeNV;
    }
}
#endif