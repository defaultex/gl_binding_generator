#if (GL_APPLE_aux_depth_stencil && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_AUX_DEPTH_STENCIL_APPLE = 0x8A14;
    }
}
#endif