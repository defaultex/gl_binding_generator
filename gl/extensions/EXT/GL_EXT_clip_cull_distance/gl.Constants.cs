#if (GL_EXT_clip_cull_distance && GLES2_API)
public partial class ext { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_CLIP_DISTANCES_EXT = 0x0D32;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_CLIP_DISTANCE0_EXT = 0x3000;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_CLIP_DISTANCE1_EXT = 0x3001;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_CLIP_DISTANCE2_EXT = 0x3002;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_CLIP_DISTANCE3_EXT = 0x3003;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_CLIP_DISTANCE4_EXT = 0x3004;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_CLIP_DISTANCE5_EXT = 0x3005;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_CLIP_DISTANCE6_EXT = 0x3006;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_CLIP_DISTANCE7_EXT = 0x3007;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_CULL_DISTANCES_EXT = 0x82F9;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_COMBINED_CLIP_AND_CULL_DISTANCES_EXT = 0x82FA;
#endif
    }
}
#endif