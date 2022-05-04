#if (GL_EXT_texture_format_sRGB_override && GLES2_API)
public partial class ext { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_FORMAT_SRGB_OVERRIDE_EXT = 0x8FBF;
#endif
    }
}
#endif