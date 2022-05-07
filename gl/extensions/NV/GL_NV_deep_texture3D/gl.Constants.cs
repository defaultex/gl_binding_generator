#if (GL_NV_deep_texture3D && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_MAX_DEEP_3D_TEXTURE_WIDTH_HEIGHT_NV = 0x90D0;
        public const GLenum GL_MAX_DEEP_3D_TEXTURE_DEPTH_NV = 0x90D1;
    }
}
#endif