#if (GL_EXT_secondary_color && GL_API)
public partial class ext { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_COLOR_SUM_EXT = 0x8458;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_CURRENT_SECONDARY_COLOR_EXT = 0x8459;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SECONDARY_COLOR_ARRAY_SIZE_EXT = 0x845A;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SECONDARY_COLOR_ARRAY_TYPE_EXT = 0x845B;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SECONDARY_COLOR_ARRAY_STRIDE_EXT = 0x845C;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SECONDARY_COLOR_ARRAY_POINTER_EXT = 0x845D;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SECONDARY_COLOR_ARRAY_EXT = 0x845E;
#endif
    }
}
#endif