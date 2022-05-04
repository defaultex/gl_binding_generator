#if (GL_SGIX_ycrcba && GL_API)
public partial class sgix { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_YCRCB_SGIX = 0x8318;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_YCRCBA_SGIX = 0x8319;
#endif
    }
}
#endif