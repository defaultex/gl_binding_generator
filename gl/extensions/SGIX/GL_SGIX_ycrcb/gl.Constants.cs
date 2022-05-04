#if (GL_SGIX_ycrcb && GL_API)
public partial class sgix { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_YCRCB_422_SGIX = 0x81BB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_YCRCB_444_SGIX = 0x81BC;
#endif
    }
}
#endif