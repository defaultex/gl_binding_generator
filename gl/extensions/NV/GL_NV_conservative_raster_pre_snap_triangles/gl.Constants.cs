#if (GL_NV_conservative_raster_pre_snap_triangles && (GL_API || GLCORE_API || GLES2_API))
public partial class glext_nv { 
    public partial class Constants { 
        public const GLenum GL_CONSERVATIVE_RASTER_MODE_NV = 0x954D;
        public const GLenum GL_CONSERVATIVE_RASTER_MODE_POST_SNAP_NV = 0x954E;
        public const GLenum GL_CONSERVATIVE_RASTER_MODE_PRE_SNAP_TRIANGLES_NV = 0x954F;
    }
}
#endif