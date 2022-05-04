#if (GL_NV_register_combiners && GL_API)
public partial class nv { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_NONE = 0;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_ZERO = 0;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_FOG = 0x0B60;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE0_ARB = 0x84C0;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE1_ARB = 0x84C1;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_REGISTER_COMBINERS_NV = 0x8522;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_VARIABLE_A_NV = 0x8523;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_VARIABLE_B_NV = 0x8524;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_VARIABLE_C_NV = 0x8525;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_VARIABLE_D_NV = 0x8526;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_VARIABLE_E_NV = 0x8527;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_VARIABLE_F_NV = 0x8528;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_VARIABLE_G_NV = 0x8529;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_CONSTANT_COLOR0_NV = 0x852A;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_CONSTANT_COLOR1_NV = 0x852B;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PRIMARY_COLOR_NV = 0x852C;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SECONDARY_COLOR_NV = 0x852D;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SPARE0_NV = 0x852E;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SPARE1_NV = 0x852F;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_DISCARD_NV = 0x8530;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_E_TIMES_F_NV = 0x8531;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SPARE0_PLUS_SECONDARY_COLOR_NV = 0x8532;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_UNSIGNED_IDENTITY_NV = 0x8536;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_UNSIGNED_INVERT_NV = 0x8537;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_EXPAND_NORMAL_NV = 0x8538;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_EXPAND_NEGATE_NV = 0x8539;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_HALF_BIAS_NORMAL_NV = 0x853A;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_HALF_BIAS_NEGATE_NV = 0x853B;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SIGNED_IDENTITY_NV = 0x853C;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SIGNED_NEGATE_NV = 0x853D;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SCALE_BY_TWO_NV = 0x853E;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SCALE_BY_FOUR_NV = 0x853F;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SCALE_BY_ONE_HALF_NV = 0x8540;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_BIAS_BY_NEGATIVE_ONE_HALF_NV = 0x8541;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_COMBINER_INPUT_NV = 0x8542;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_COMBINER_MAPPING_NV = 0x8543;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_COMBINER_COMPONENT_USAGE_NV = 0x8544;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_COMBINER_AB_DOT_PRODUCT_NV = 0x8545;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_COMBINER_CD_DOT_PRODUCT_NV = 0x8546;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_COMBINER_MUX_SUM_NV = 0x8547;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_COMBINER_SCALE_NV = 0x8548;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_COMBINER_BIAS_NV = 0x8549;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_COMBINER_AB_OUTPUT_NV = 0x854A;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_COMBINER_CD_OUTPUT_NV = 0x854B;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_COMBINER_SUM_OUTPUT_NV = 0x854C;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_GENERAL_COMBINERS_NV = 0x854D;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_NUM_GENERAL_COMBINERS_NV = 0x854E;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_COLOR_SUM_CLAMP_NV = 0x854F;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_COMBINER0_NV = 0x8550;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_COMBINER1_NV = 0x8551;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_COMBINER2_NV = 0x8552;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_COMBINER3_NV = 0x8553;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_COMBINER4_NV = 0x8554;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_COMBINER5_NV = 0x8555;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_COMBINER6_NV = 0x8556;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_COMBINER7_NV = 0x8557;
#endif
    }
}
#endif