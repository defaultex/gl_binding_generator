#if (GL_EXT_stencil_clear_tag && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_STENCIL_TAG_BITS_EXT = 0x88F2;
        public const GLenum GL_STENCIL_CLEAR_TAG_VALUE_EXT = 0x88F3;
    }
}
#endif