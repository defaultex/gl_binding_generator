#if (GL_EXT_texture_compression_rgtc && (!gl || !gles2))
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_COMPRESSED_RED_RGTC1_EXT = 0x8DBB;
        public const GLenum GL_COMPRESSED_SIGNED_RED_RGTC1_EXT = 0x8DBC;
        public const GLenum GL_COMPRESSED_RED_GREEN_RGTC2_EXT = 0x8DBD;
        public const GLenum GL_COMPRESSED_SIGNED_RED_GREEN_RGTC2_EXT = 0x8DBE;
    }
}
#endif