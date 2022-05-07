#if (GL_EXT_packed_depth_stencil && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_DEPTH_STENCIL_EXT = 0x84F9;
        public const GLenum GL_UNSIGNED_INT_24_8_EXT = 0x84FA;
        public const GLenum GL_DEPTH24_STENCIL8_EXT = 0x88F0;
        public const GLenum GL_TEXTURE_STENCIL_SIZE_EXT = 0x88F1;
    }
}
#endif