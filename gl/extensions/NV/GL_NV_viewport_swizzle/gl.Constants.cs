#if (GL_NV_viewport_swizzle && (!gl || !glcore || !gles2))
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_VIEWPORT_SWIZZLE_POSITIVE_X_NV = 0x9350;
        public const GLenum GL_VIEWPORT_SWIZZLE_NEGATIVE_X_NV = 0x9351;
        public const GLenum GL_VIEWPORT_SWIZZLE_POSITIVE_Y_NV = 0x9352;
        public const GLenum GL_VIEWPORT_SWIZZLE_NEGATIVE_Y_NV = 0x9353;
        public const GLenum GL_VIEWPORT_SWIZZLE_POSITIVE_Z_NV = 0x9354;
        public const GLenum GL_VIEWPORT_SWIZZLE_NEGATIVE_Z_NV = 0x9355;
        public const GLenum GL_VIEWPORT_SWIZZLE_POSITIVE_W_NV = 0x9356;
        public const GLenum GL_VIEWPORT_SWIZZLE_NEGATIVE_W_NV = 0x9357;
        public const GLenum GL_VIEWPORT_SWIZZLE_X_NV = 0x9358;
        public const GLenum GL_VIEWPORT_SWIZZLE_Y_NV = 0x9359;
        public const GLenum GL_VIEWPORT_SWIZZLE_Z_NV = 0x935A;
        public const GLenum GL_VIEWPORT_SWIZZLE_W_NV = 0x935B;
    }
}
#endif