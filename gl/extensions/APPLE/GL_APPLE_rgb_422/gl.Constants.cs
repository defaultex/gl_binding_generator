#if (GL_APPLE_rgb_422 && (GL_API || GLCORE_API || GLES2_API))
public partial class apple { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_UNSIGNED_SHORT_8_8_APPLE = 0x85BA;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_UNSIGNED_SHORT_8_8_REV_APPLE = 0x85BB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_RGB_422_APPLE = 0x8A1F;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_RGB_RAW_422_APPLE = 0x8A51;
#endif
    }
}
#endif