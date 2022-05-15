#if GL_NV_fragment_coverage_to_color

public partial class gl { 
    public partial class Functions { 

        /// <summary>void glFragmentCoverageColorNV(GLuint color);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, void> glFragmentCoverageColorNV;
    }
}

#endif