#if (GL_NV_tessellation_program5 && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_MAX_PROGRAM_PATCH_ATTRIBS_NV = 0x86D8;
        public const GLenum GL_TESS_CONTROL_PROGRAM_NV = 0x891E;
        public const GLenum GL_TESS_EVALUATION_PROGRAM_NV = 0x891F;
        public const GLenum GL_TESS_CONTROL_PROGRAM_PARAMETER_BUFFER_NV = 0x8C74;
        public const GLenum GL_TESS_EVALUATION_PROGRAM_PARAMETER_BUFFER_NV = 0x8C75;
    }
}
#endif