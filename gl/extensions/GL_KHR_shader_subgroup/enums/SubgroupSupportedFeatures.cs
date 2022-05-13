#if GL_KHR_shader_subgroup

public enum SubgroupSupportedFeatures : GLenum {
#if GL_KHR_shader_subgroup
    SubgroupFeatureBasicBitKhr = gl.Constants.GL_SUBGROUP_FEATURE_BASIC_BIT_KHR,
#endif

#if GL_KHR_shader_subgroup
    SubgroupFeatureVoteBitKhr = gl.Constants.GL_SUBGROUP_FEATURE_VOTE_BIT_KHR,
#endif

#if GL_KHR_shader_subgroup
    SubgroupFeatureArithmeticBitKhr = gl.Constants.GL_SUBGROUP_FEATURE_ARITHMETIC_BIT_KHR,
#endif

#if GL_KHR_shader_subgroup
    SubgroupFeatureBallotBitKhr = gl.Constants.GL_SUBGROUP_FEATURE_BALLOT_BIT_KHR,
#endif

#if GL_KHR_shader_subgroup
    SubgroupFeatureShuffleBitKhr = gl.Constants.GL_SUBGROUP_FEATURE_SHUFFLE_BIT_KHR,
#endif

#if GL_KHR_shader_subgroup
    SubgroupFeatureShuffleRelativeBitKhr = gl.Constants.GL_SUBGROUP_FEATURE_SHUFFLE_RELATIVE_BIT_KHR,
#endif

#if GL_KHR_shader_subgroup
    SubgroupFeatureClusteredBitKhr = gl.Constants.GL_SUBGROUP_FEATURE_CLUSTERED_BIT_KHR,
#endif

#if GL_KHR_shader_subgroup
    SubgroupFeatureQuadBitKhr = gl.Constants.GL_SUBGROUP_FEATURE_QUAD_BIT_KHR,
#endif

#if GL_NV_shader_subgroup_partitioned
    SubgroupFeaturePartitionedBitNv = gl.Constants.GL_SUBGROUP_FEATURE_PARTITIONED_BIT_NV,
#endif
}

#endif