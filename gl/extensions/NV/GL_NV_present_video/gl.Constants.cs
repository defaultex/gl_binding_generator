#if (GL_NV_present_video && GL_API)
public partial class nv { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_FRAME_NV = 0x8E26;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_FIELDS_NV = 0x8E27;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_CURRENT_TIME_NV = 0x8E28;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_NUM_FILL_STREAMS_NV = 0x8E29;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PRESENT_TIME_NV = 0x8E2A;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PRESENT_DURATION_NV = 0x8E2B;
#endif
    }
}
#endif