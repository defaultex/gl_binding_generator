#if (GL_NV_fragment_program && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_MAX_FRAGMENT_PROGRAM_LOCAL_PARAMETERS_NV = 0x8868;
        public const GLenum GL_FRAGMENT_PROGRAM_NV = 0x8870;
        public const GLenum GL_MAX_TEXTURE_COORDS_NV = 0x8871;
        public const GLenum GL_MAX_TEXTURE_IMAGE_UNITS_NV = 0x8872;
        public const GLenum GL_FRAGMENT_PROGRAM_BINDING_NV = 0x8873;
        public const GLenum GL_PROGRAM_ERROR_STRING_NV = 0x8874;
    }
}
#endif