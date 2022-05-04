#if (GL_NV_conservative_raster_pre_snap_triangles && (GL_API || GLCORE_API || GLES2_API))
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glConservativeRasterParameteriNV(GLenum pname, GLint param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, GLint, void> glConservativeRasterParameteriNV;
#endif
    }
}
#endif