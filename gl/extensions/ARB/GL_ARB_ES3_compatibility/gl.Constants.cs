#if (GL_ARB_ES3_compatibility && (!gl || !glcore))
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_PRIMITIVE_RESTART_FIXED_INDEX = 0x8D69;
        public const GLenum GL_ANY_SAMPLES_PASSED_CONSERVATIVE = 0x8D6A;
        public const GLenum GL_MAX_ELEMENT_INDEX = 0x8D6B;
        public const GLenum GL_COMPRESSED_R11_EAC = 0x9270;
        public const GLenum GL_COMPRESSED_SIGNED_R11_EAC = 0x9271;
        public const GLenum GL_COMPRESSED_RG11_EAC = 0x9272;
        public const GLenum GL_COMPRESSED_SIGNED_RG11_EAC = 0x9273;
        public const GLenum GL_COMPRESSED_RGB8_ETC2 = 0x9274;
        public const GLenum GL_COMPRESSED_SRGB8_ETC2 = 0x9275;
        public const GLenum GL_COMPRESSED_RGB8_PUNCHTHROUGH_ALPHA1_ETC2 = 0x9276;
        public const GLenum GL_COMPRESSED_SRGB8_PUNCHTHROUGH_ALPHA1_ETC2 = 0x9277;
        public const GLenum GL_COMPRESSED_RGBA8_ETC2_EAC = 0x9278;
        public const GLenum GL_COMPRESSED_SRGB8_ALPHA8_ETC2_EAC = 0x9279;
    }
}
#endif