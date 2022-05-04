#if (GL_EXT_occlusion_query_boolean && GLES2_API)
public partial class ext { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_CURRENT_QUERY_EXT = 0x8865;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_QUERY_RESULT_EXT = 0x8866;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_QUERY_RESULT_AVAILABLE_EXT = 0x8867;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_ANY_SAMPLES_PASSED_EXT = 0x8C2F;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_ANY_SAMPLES_PASSED_CONSERVATIVE_EXT = 0x8D6A;
#endif
    }
}
#endif