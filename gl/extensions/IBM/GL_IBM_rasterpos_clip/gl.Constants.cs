#if (GL_IBM_rasterpos_clip && GL_API)
public partial class ibm { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_RASTER_POSITION_UNCLIPPED_IBM = 0x19262;
#endif
    }
}
#endif