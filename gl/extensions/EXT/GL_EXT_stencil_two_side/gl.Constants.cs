#if (GL_EXT_stencil_two_side && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_STENCIL_TEST_TWO_SIDE_EXT = 0x8910;
        public const GLenum GL_ACTIVE_STENCIL_FACE_EXT = 0x8911;
    }
}
#endif