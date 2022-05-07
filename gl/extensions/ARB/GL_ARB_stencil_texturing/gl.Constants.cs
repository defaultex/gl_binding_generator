#if (GL_ARB_stencil_texturing && (!gl || !glcore))
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_DEPTH_STENCIL_TEXTURE_MODE = 0x90EA;
    }
}
#endif