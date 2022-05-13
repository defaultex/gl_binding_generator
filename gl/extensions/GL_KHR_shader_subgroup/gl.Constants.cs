#if GL_KHR_shader_subgroup

public partial class gl { 
    public partial class Constants {
        public const GLenum GL_SUBGROUP_FEATURE_BASIC_BIT_KHR = 0x00000001;
        public const GLenum GL_SUBGROUP_FEATURE_VOTE_BIT_KHR = 0x00000002;
        public const GLenum GL_SUBGROUP_FEATURE_ARITHMETIC_BIT_KHR = 0x00000004;
        public const GLenum GL_SUBGROUP_FEATURE_BALLOT_BIT_KHR = 0x00000008;
        public const GLenum GL_SUBGROUP_FEATURE_SHUFFLE_BIT_KHR = 0x00000010;
        public const GLenum GL_SUBGROUP_FEATURE_SHUFFLE_RELATIVE_BIT_KHR = 0x00000020;
        public const GLenum GL_SUBGROUP_FEATURE_CLUSTERED_BIT_KHR = 0x00000040;
        public const GLenum GL_SUBGROUP_FEATURE_QUAD_BIT_KHR = 0x00000080;
        public const GLenum GL_SUBGROUP_SIZE_KHR = 0x9532;
        public const GLenum GL_SUBGROUP_SUPPORTED_STAGES_KHR = 0x9533;
        public const GLenum GL_SUBGROUP_SUPPORTED_FEATURES_KHR = 0x9534;
        public const GLenum GL_SUBGROUP_QUAD_ALL_STAGES_KHR = 0x9535;
    }
}

#endif