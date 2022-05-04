#if (GL_IBM_vertex_array_lists && GL_API)
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glColorPointerListIBM(GLint size, GLenum type, GLint stride, void** pointer, GLint ptrstride);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, ColorPointerType, GLint, void**, GLint, void> glColorPointerListIBM;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glEdgeFlagPointerListIBM(GLint stride, GLboolean** pointer, GLint ptrstride);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLboolean**, GLint, void> glEdgeFlagPointerListIBM;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glFogCoordPointerListIBM(GLenum type, GLint stride, void** pointer, GLint ptrstride);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FogPointerTypeIBM, GLint, void**, GLint, void> glFogCoordPointerListIBM;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glIndexPointerListIBM(GLenum type, GLint stride, void** pointer, GLint ptrstride);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<IndexPointerType, GLint, void**, GLint, void> glIndexPointerListIBM;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glNormalPointerListIBM(GLenum type, GLint stride, void** pointer, GLint ptrstride);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<NormalPointerType, GLint, void**, GLint, void> glNormalPointerListIBM;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glSecondaryColorPointerListIBM(GLint size, GLenum type, GLint stride, void** pointer, GLint ptrstride);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, SecondaryColorPointerTypeIBM, GLint, void**, GLint, void> glSecondaryColorPointerListIBM;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glTexCoordPointerListIBM(GLint size, GLenum type, GLint stride, void** pointer, GLint ptrstride);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, TexCoordPointerType, GLint, void**, GLint, void> glTexCoordPointerListIBM;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexPointerListIBM(GLint size, GLenum type, GLint stride, void** pointer, GLint ptrstride);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, VertexPointerType, GLint, void**, GLint, void> glVertexPointerListIBM;
#endif
    }
}
#endif