#if (GL_NV_packed_depth_stencil && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_DEPTH_STENCIL_NV = 0x84F9;
        public const GLenum GL_UNSIGNED_INT_24_8_NV = 0x84FA;
    }
}
#endif