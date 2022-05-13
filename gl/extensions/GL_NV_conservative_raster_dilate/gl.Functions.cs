#if GL_NV_conservative_raster_dilate

public partial class gl { 
    public partial class Functions { 
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, GLfloat, void> glConservativeRasterParameterfNV;
    }
}

#endif