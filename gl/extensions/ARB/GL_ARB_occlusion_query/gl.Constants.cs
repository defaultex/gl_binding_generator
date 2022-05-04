#if (GL_ARB_occlusion_query && GL_API)
public partial class arb { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_QUERY_COUNTER_BITS_ARB = 0x8864;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_CURRENT_QUERY_ARB = 0x8865;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_QUERY_RESULT_ARB = 0x8866;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_QUERY_RESULT_AVAILABLE_ARB = 0x8867;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SAMPLES_PASSED_ARB = 0x8914;
#endif
    }
}
#endif