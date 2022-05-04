#if (GL_EXT_texture_swizzle && GL_API)
public partial class ext { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_SWIZZLE_R_EXT = 0x8E42;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_SWIZZLE_G_EXT = 0x8E43;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_SWIZZLE_B_EXT = 0x8E44;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_SWIZZLE_A_EXT = 0x8E45;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_SWIZZLE_RGBA_EXT = 0x8E46;
#endif
    }
}
#endif