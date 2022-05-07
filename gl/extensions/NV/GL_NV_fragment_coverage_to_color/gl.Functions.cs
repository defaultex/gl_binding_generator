#if (GL_NV_fragment_coverage_to_color && (!gl || !glcore || !gles2))
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glFragmentCoverageColorNV(GLuint color);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, void> glFragmentCoverageColorNV;
    }
}
#endif