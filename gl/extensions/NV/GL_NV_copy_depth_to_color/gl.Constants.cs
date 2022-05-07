#if (GL_NV_copy_depth_to_color && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_DEPTH_STENCIL_TO_RGBA_NV = 0x886E;
        public const GLenum GL_DEPTH_STENCIL_TO_BGRA_NV = 0x886F;
    }
}
#endif