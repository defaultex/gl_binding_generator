#if (GL_ARB_pipeline_statistics_query && (GL_API || GLCORE_API))
public partial class arb { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_VERTICES_SUBMITTED_ARB = 0x82EE;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PRIMITIVES_SUBMITTED_ARB = 0x82EF;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_VERTEX_SHADER_INVOCATIONS_ARB = 0x82F0;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TESS_CONTROL_SHADER_PATCHES_ARB = 0x82F1;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TESS_EVALUATION_SHADER_INVOCATIONS_ARB = 0x82F2;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_GEOMETRY_SHADER_PRIMITIVES_EMITTED_ARB = 0x82F3;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_FRAGMENT_SHADER_INVOCATIONS_ARB = 0x82F4;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_COMPUTE_SHADER_INVOCATIONS_ARB = 0x82F5;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_CLIPPING_INPUT_PRIMITIVES_ARB = 0x82F6;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_CLIPPING_OUTPUT_PRIMITIVES_ARB = 0x82F7;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_GEOMETRY_SHADER_INVOCATIONS = 0x887F;
#endif
    }
}
#endif