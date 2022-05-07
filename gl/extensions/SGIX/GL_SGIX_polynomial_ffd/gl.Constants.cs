#if (GL_SGIX_polynomial_ffd && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_TEXTURE_DEFORMATION_BIT_SGIX = 0x00000001;
        public const GLenum GL_GEOMETRY_DEFORMATION_BIT_SGIX = 0x00000002;
        public const GLenum GL_GEOMETRY_DEFORMATION_SGIX = 0x8194;
        public const GLenum GL_TEXTURE_DEFORMATION_SGIX = 0x8195;
        public const GLenum GL_DEFORMATIONS_MASK_SGIX = 0x8196;
        public const GLenum GL_MAX_DEFORMATION_ORDER_SGIX = 0x8197;
    }
}
#endif