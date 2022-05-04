#if (GL_NV_vertex_array_range && GL_API)
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glFlushVertexArrayRangeNV();</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void> glFlushVertexArrayRangeNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexArrayRangeNV(GLsizei length, void* pointer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, void*, void> glVertexArrayRangeNV;
#endif
    }
}
#endif