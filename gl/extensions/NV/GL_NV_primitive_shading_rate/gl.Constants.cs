#if (GL_NV_primitive_shading_rate && (GL_API || GLCORE_API || GLES2_API))
public partial class glext_nv { 
    public partial class Constants { 
        public const GLenum GL_SHADING_RATE_IMAGE_PER_PRIMITIVE_NV = 0x95B1;
        public const GLenum GL_SHADING_RATE_IMAGE_PALETTE_COUNT_NV = 0x95B2;
    }
}
#endif