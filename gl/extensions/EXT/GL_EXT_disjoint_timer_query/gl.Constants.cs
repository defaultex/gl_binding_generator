#if (GL_EXT_disjoint_timer_query && GLES2_API)
public partial class ext { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_QUERY_COUNTER_BITS_EXT = 0x8864;
#endif

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
        public const GLenum GL_TIME_ELAPSED_EXT = 0x88BF;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TIMESTAMP_EXT = 0x8E28;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_GPU_DISJOINT_EXT = 0x8FBB;
#endif
    }
}
#endif