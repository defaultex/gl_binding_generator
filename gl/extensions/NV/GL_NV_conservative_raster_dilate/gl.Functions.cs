#if (GL_NV_conservative_raster_dilate && (!gl || !glcore))
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glConservativeRasterParameterfNV(GLenum pname, GLfloat value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, GLfloat, void> glConservativeRasterParameterfNV;
    }
}
#endif