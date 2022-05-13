#if GL_NV_conservative_raster

public partial class gl { 
    public partial class Functions { 
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint, void> glSubpixelPrecisionBiasNV;
    }
}

#endif