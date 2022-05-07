#if (GL_IBM_vertex_array_lists && !gl)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glColorPointerListIBM(GLint size, GLenum type, GLint stride, void** pointer, GLint ptrstride);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, ColorPointerType, GLint, void**, GLint, void> glColorPointerListIBM;

        /// <summary>void glEdgeFlagPointerListIBM(GLint stride, GLboolean** pointer, GLint ptrstride);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLboolean**, GLint, void> glEdgeFlagPointerListIBM;

        /// <summary>void glFogCoordPointerListIBM(GLenum type, GLint stride, void** pointer, GLint ptrstride);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FogPointerTypeIBM, GLint, void**, GLint, void> glFogCoordPointerListIBM;

        /// <summary>void glIndexPointerListIBM(GLenum type, GLint stride, void** pointer, GLint ptrstride);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<IndexPointerType, GLint, void**, GLint, void> glIndexPointerListIBM;

        /// <summary>void glNormalPointerListIBM(GLenum type, GLint stride, void** pointer, GLint ptrstride);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<NormalPointerType, GLint, void**, GLint, void> glNormalPointerListIBM;

        /// <summary>void glSecondaryColorPointerListIBM(GLint size, GLenum type, GLint stride, void** pointer, GLint ptrstride);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, SecondaryColorPointerTypeIBM, GLint, void**, GLint, void> glSecondaryColorPointerListIBM;

        /// <summary>void glTexCoordPointerListIBM(GLint size, GLenum type, GLint stride, void** pointer, GLint ptrstride);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, TexCoordPointerType, GLint, void**, GLint, void> glTexCoordPointerListIBM;

        /// <summary>void glVertexPointerListIBM(GLint size, GLenum type, GLint stride, void** pointer, GLint ptrstride);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, VertexPointerType, GLint, void**, GLint, void> glVertexPointerListIBM;
    }
}
#endif