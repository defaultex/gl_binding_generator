#if (GL_EXT_clip_control && GLES2_API)
public partial class ext { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_LOWER_LEFT_EXT = 0x8CA1;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_UPPER_LEFT_EXT = 0x8CA2;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_CLIP_ORIGIN_EXT = 0x935C;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_CLIP_DEPTH_MODE_EXT = 0x935D;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_NEGATIVE_ONE_TO_ONE_EXT = 0x935E;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_ZERO_TO_ONE_EXT = 0x935F;
#endif
    }
}
#endif