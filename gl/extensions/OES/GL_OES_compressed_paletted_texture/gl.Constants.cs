#if (GL_OES_compressed_paletted_texture && (!gl || !gles1 || !gles2))
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_PALETTE4_RGB8_OES = 0x8B90;
        public const GLenum GL_PALETTE4_RGBA8_OES = 0x8B91;
        public const GLenum GL_PALETTE4_R5_G6_B5_OES = 0x8B92;
        public const GLenum GL_PALETTE4_RGBA4_OES = 0x8B93;
        public const GLenum GL_PALETTE4_RGB5_A1_OES = 0x8B94;
        public const GLenum GL_PALETTE8_RGB8_OES = 0x8B95;
        public const GLenum GL_PALETTE8_RGBA8_OES = 0x8B96;
        public const GLenum GL_PALETTE8_R5_G6_B5_OES = 0x8B97;
        public const GLenum GL_PALETTE8_RGBA4_OES = 0x8B98;
        public const GLenum GL_PALETTE8_RGB5_A1_OES = 0x8B99;
    }
}
#endif