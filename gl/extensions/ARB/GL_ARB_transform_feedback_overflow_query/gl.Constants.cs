#if (GL_ARB_transform_feedback_overflow_query && (GL_API || GLCORE_API))
public partial class arb { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TRANSFORM_FEEDBACK_OVERFLOW_ARB = 0x82EC;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TRANSFORM_FEEDBACK_STREAM_OVERFLOW_ARB = 0x82ED;
#endif
    }
}
#endif