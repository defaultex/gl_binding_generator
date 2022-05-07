#if (GL_INTEL_parallel_arrays && !gl)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glColorPointervINTEL(GLint size, GLenum type, void** pointer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, VertexPointerType, void**, void> glColorPointervINTEL;

        /// <summary>void glNormalPointervINTEL(GLenum type, void** pointer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<NormalPointerType, void**, void> glNormalPointervINTEL;

        /// <summary>void glTexCoordPointervINTEL(GLint size, GLenum type, void** pointer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, VertexPointerType, void**, void> glTexCoordPointervINTEL;

        /// <summary>void glVertexPointervINTEL(GLint size, GLenum type, void** pointer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, VertexPointerType, void**, void> glVertexPointervINTEL;
    }
}
#endif