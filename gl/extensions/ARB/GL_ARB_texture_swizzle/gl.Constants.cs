#if (GL_ARB_texture_swizzle && (!gl || !glcore))
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_TEXTURE_SWIZZLE_R = 0x8E42;
        public const GLenum GL_TEXTURE_SWIZZLE_G = 0x8E43;
        public const GLenum GL_TEXTURE_SWIZZLE_B = 0x8E44;
        public const GLenum GL_TEXTURE_SWIZZLE_A = 0x8E45;
        public const GLenum GL_TEXTURE_SWIZZLE_RGBA = 0x8E46;
    }
}
#endif