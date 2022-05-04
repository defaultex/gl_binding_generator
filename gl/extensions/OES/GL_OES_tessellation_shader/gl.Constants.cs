#if (GL_OES_tessellation_shader && GLES2_API)
public partial class oes { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_TRIANGLES = 0x0004;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_QUADS_OES = 0x0007;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TESS_CONTROL_SHADER_BIT_OES = 0x00000008;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PATCHES_OES = 0x000E;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TESS_EVALUATION_SHADER_BIT_OES = 0x00000010;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_EQUAL = 0x0202;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_CW = 0x0900;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_CCW = 0x0901;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PRIMITIVE_RESTART_FOR_PATCHES_SUPPORTED_OES = 0x8221;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_TESS_CONTROL_INPUT_COMPONENTS_OES = 0x886C;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_TESS_EVALUATION_INPUT_COMPONENTS_OES = 0x886D;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_COMBINED_TESS_CONTROL_UNIFORM_COMPONENTS_OES = 0x8E1E;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_COMBINED_TESS_EVALUATION_UNIFORM_COMPONENTS_OES = 0x8E1F;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PATCH_VERTICES_OES = 0x8E72;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TESS_CONTROL_OUTPUT_VERTICES_OES = 0x8E75;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TESS_GEN_MODE_OES = 0x8E76;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TESS_GEN_SPACING_OES = 0x8E77;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TESS_GEN_VERTEX_ORDER_OES = 0x8E78;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TESS_GEN_POINT_MODE_OES = 0x8E79;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_ISOLINES_OES = 0x8E7A;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_FRACTIONAL_ODD_OES = 0x8E7B;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_FRACTIONAL_EVEN_OES = 0x8E7C;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_PATCH_VERTICES_OES = 0x8E7D;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_TESS_GEN_LEVEL_OES = 0x8E7E;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_TESS_CONTROL_UNIFORM_COMPONENTS_OES = 0x8E7F;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_TESS_EVALUATION_UNIFORM_COMPONENTS_OES = 0x8E80;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_TESS_CONTROL_TEXTURE_IMAGE_UNITS_OES = 0x8E81;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_TESS_EVALUATION_TEXTURE_IMAGE_UNITS_OES = 0x8E82;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_TESS_CONTROL_OUTPUT_COMPONENTS_OES = 0x8E83;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_TESS_PATCH_COMPONENTS_OES = 0x8E84;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_TESS_CONTROL_TOTAL_OUTPUT_COMPONENTS_OES = 0x8E85;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_TESS_EVALUATION_OUTPUT_COMPONENTS_OES = 0x8E86;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TESS_EVALUATION_SHADER_OES = 0x8E87;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TESS_CONTROL_SHADER_OES = 0x8E88;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_TESS_CONTROL_UNIFORM_BLOCKS_OES = 0x8E89;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_TESS_EVALUATION_UNIFORM_BLOCKS_OES = 0x8E8A;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_TESS_CONTROL_IMAGE_UNIFORMS_OES = 0x90CB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_TESS_EVALUATION_IMAGE_UNIFORMS_OES = 0x90CC;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_TESS_CONTROL_SHADER_STORAGE_BLOCKS_OES = 0x90D8;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_TESS_EVALUATION_SHADER_STORAGE_BLOCKS_OES = 0x90D9;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_TESS_CONTROL_ATOMIC_COUNTER_BUFFERS_OES = 0x92CD;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_TESS_EVALUATION_ATOMIC_COUNTER_BUFFERS_OES = 0x92CE;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_TESS_CONTROL_ATOMIC_COUNTERS_OES = 0x92D3;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_TESS_EVALUATION_ATOMIC_COUNTERS_OES = 0x92D4;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_IS_PER_PATCH_OES = 0x92E7;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_REFERENCED_BY_TESS_CONTROL_SHADER_OES = 0x9307;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_REFERENCED_BY_TESS_EVALUATION_SHADER_OES = 0x9308;
#endif
    }
}
#endif