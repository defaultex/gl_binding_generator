#if (GL_EXT_texture_swizzle && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_TEXTURE_SWIZZLE_R_EXT = 0x8E42;
        public const GLenum GL_TEXTURE_SWIZZLE_G_EXT = 0x8E43;
        public const GLenum GL_TEXTURE_SWIZZLE_B_EXT = 0x8E44;
        public const GLenum GL_TEXTURE_SWIZZLE_A_EXT = 0x8E45;
        public const GLenum GL_TEXTURE_SWIZZLE_RGBA_EXT = 0x8E46;
    }
}
#endif