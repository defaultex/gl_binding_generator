#if (GL_KHR_SHADER_SUBGROUP || GL_NV_SHADER_SUBGROUP_PARTITIONED)

public enum SubgroupSupportedFeatures : GLenum { 
#if GL_KHR_SHADER_SUBGROUP
    FeatureBasicBitKhr = gl.Constants.GL_SUBGROUP_FEATURE_BASIC_BIT_KHR, 
#endif

#if GL_KHR_SHADER_SUBGROUP
    FeatureVoteBitKhr = gl.Constants.GL_SUBGROUP_FEATURE_VOTE_BIT_KHR, 
#endif

#if GL_KHR_SHADER_SUBGROUP
    FeatureArithmeticBitKhr = gl.Constants.GL_SUBGROUP_FEATURE_ARITHMETIC_BIT_KHR, 
#endif

#if GL_KHR_SHADER_SUBGROUP
    FeatureBallotBitKhr = gl.Constants.GL_SUBGROUP_FEATURE_BALLOT_BIT_KHR, 
#endif

#if GL_KHR_SHADER_SUBGROUP
    FeatureShuffleBitKhr = gl.Constants.GL_SUBGROUP_FEATURE_SHUFFLE_BIT_KHR, 
#endif

#if GL_KHR_SHADER_SUBGROUP
    FeatureShuffleRelativeBitKhr = gl.Constants.GL_SUBGROUP_FEATURE_SHUFFLE_RELATIVE_BIT_KHR, 
#endif

#if GL_KHR_SHADER_SUBGROUP
    FeatureClusteredBitKhr = gl.Constants.GL_SUBGROUP_FEATURE_CLUSTERED_BIT_KHR, 
#endif

#if GL_KHR_SHADER_SUBGROUP
    FeatureQuadBitKhr = gl.Constants.GL_SUBGROUP_FEATURE_QUAD_BIT_KHR, 
#endif

#if GL_NV_SHADER_SUBGROUP_PARTITIONED
    FeaturePartitionedBitNv = gl.Constants.GL_SUBGROUP_FEATURE_PARTITIONED_BIT_NV, 
#endif

}

#endif
