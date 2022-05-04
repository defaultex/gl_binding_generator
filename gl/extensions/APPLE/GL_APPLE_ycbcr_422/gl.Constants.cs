#if (GL_APPLE_ycbcr_422 && GL_API)
public partial class apple { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_YCBCR_422_APPLE = 0x85B9;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_UNSIGNED_SHORT_8_8_APPLE = 0x85BA;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_UNSIGNED_SHORT_8_8_REV_APPLE = 0x85BB;
#endif
    }
}
#endif