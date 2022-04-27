#if (GL_NV_coverage_sample && GLES2_API)
public partial class gles2 { 
    public partial class Functions { 
        /// <summary>void glCoverageMaskNV(GLboolean mask)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLboolean, void> glCoverageMaskNV;

        /// <summary>void glCoverageOperationNV(GLenum operation)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, void> glCoverageOperationNV;
    }
}
#endif