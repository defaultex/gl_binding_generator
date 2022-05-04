#if (GL_NV_conservative_raster_pre_snap && (GL_API || GLCORE_API || GLES2_API))
public partial class nv { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_CONSERVATIVE_RASTER_MODE_PRE_SNAP_NV = 0x9550;
#endif
    }
}
#endif