#if (GL_INTEL_parallel_arrays && GL_API)
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glColorPointervINTEL(GLint size, GLenum type, void** pointer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, VertexPointerType, void**, void> glColorPointervINTEL;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glNormalPointervINTEL(GLenum type, void** pointer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<NormalPointerType, void**, void> glNormalPointervINTEL;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glTexCoordPointervINTEL(GLint size, GLenum type, void** pointer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, VertexPointerType, void**, void> glTexCoordPointervINTEL;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexPointervINTEL(GLint size, GLenum type, void** pointer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, VertexPointerType, void**, void> glVertexPointervINTEL;
#endif
    }
}
#endif