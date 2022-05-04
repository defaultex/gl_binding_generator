#if (GL_NV_coverage_sample && GLES2_API)
public partial class gles2 { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glCoverageMaskNV(GLboolean mask);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLboolean, void> glCoverageMaskNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glCoverageOperationNV(GLenum operation);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, void> glCoverageOperationNV;
#endif
    }
}
#endif