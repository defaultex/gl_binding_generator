#if (GL_APPLE_vertex_array_range && GL_API)
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glFlushVertexArrayRangeAPPLE(GLsizei length, void* pointer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, void*, void> glFlushVertexArrayRangeAPPLE;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexArrayParameteriAPPLE(GLenum pname, GLint param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<VertexArrayPNameAPPLE, GLint, void> glVertexArrayParameteriAPPLE;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexArrayRangeAPPLE(GLsizei length, void* pointer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, void*, void> glVertexArrayRangeAPPLE;
#endif
    }
}
#endif