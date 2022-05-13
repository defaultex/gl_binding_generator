#if GL_NV_fragment_coverage_to_color

public partial class gl { 
    public partial class Functions { 
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, void> glFragmentCoverageColorNV;
    }
}

#endif