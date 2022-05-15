#if GL_NV_conservative_raster_pre_snap_triangles

public partial class gl { 
    public partial class Functions { 

        /// <summary>void glConservativeRasterParameteriNV(GLenum pname, GLint param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, GLint, void> glConservativeRasterParameteriNV;
    }
}

#endif