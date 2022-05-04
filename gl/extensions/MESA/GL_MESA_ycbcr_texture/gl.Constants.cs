#if (GL_MESA_ycbcr_texture && GL_API)
public partial class mesa { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_UNSIGNED_SHORT_8_8_MESA = 0x85BA;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_UNSIGNED_SHORT_8_8_REV_MESA = 0x85BB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_YCBCR_MESA = 0x8757;
#endif
    }
}
#endif