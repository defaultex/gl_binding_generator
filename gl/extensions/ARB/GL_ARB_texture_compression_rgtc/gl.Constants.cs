#if (GL_ARB_texture_compression_rgtc && (!gl || !glcore))
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_COMPRESSED_RED_RGTC1 = 0x8DBB;
        public const GLenum GL_COMPRESSED_SIGNED_RED_RGTC1 = 0x8DBC;
        public const GLenum GL_COMPRESSED_RG_RGTC2 = 0x8DBD;
        public const GLenum GL_COMPRESSED_SIGNED_RG_RGTC2 = 0x8DBE;
    }
}
#endif