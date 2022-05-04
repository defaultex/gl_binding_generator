#if (GL_IMG_texture_filter_cubic && GLES2_API)
public partial class img { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_CUBIC_IMG = 0x9139;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_CUBIC_MIPMAP_NEAREST_IMG = 0x913A;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_CUBIC_MIPMAP_LINEAR_IMG = 0x913B;
#endif
    }
}
#endif