#if (GL_IMG_user_clip_plane && GLES1_API)
public partial class img { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_CLIP_PLANES_IMG = 0x0D32;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_CLIP_PLANE0_IMG = 0x3000;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_CLIP_PLANE1_IMG = 0x3001;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_CLIP_PLANE2_IMG = 0x3002;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_CLIP_PLANE3_IMG = 0x3003;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_CLIP_PLANE4_IMG = 0x3004;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_CLIP_PLANE5_IMG = 0x3005;
#endif
    }
}
#endif