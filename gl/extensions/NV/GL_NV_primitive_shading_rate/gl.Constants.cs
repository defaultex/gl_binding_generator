#if (GL_NV_primitive_shading_rate && (!gl || !glcore || !gles2))
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_SHADING_RATE_IMAGE_PER_PRIMITIVE_NV = 0x95B1;
        public const GLenum GL_SHADING_RATE_IMAGE_PALETTE_COUNT_NV = 0x95B2;
    }
}
#endif