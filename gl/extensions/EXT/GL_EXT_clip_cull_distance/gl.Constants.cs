#if (GL_EXT_clip_cull_distance && !gles2)
public partial class gles2 { 
    public partial class Constants { 
        public const GLenum GL_MAX_CLIP_DISTANCES_EXT = 0x0D32;
        public const GLenum GL_CLIP_DISTANCE0_EXT = 0x3000;
        public const GLenum GL_CLIP_DISTANCE1_EXT = 0x3001;
        public const GLenum GL_CLIP_DISTANCE2_EXT = 0x3002;
        public const GLenum GL_CLIP_DISTANCE3_EXT = 0x3003;
        public const GLenum GL_CLIP_DISTANCE4_EXT = 0x3004;
        public const GLenum GL_CLIP_DISTANCE5_EXT = 0x3005;
        public const GLenum GL_CLIP_DISTANCE6_EXT = 0x3006;
        public const GLenum GL_CLIP_DISTANCE7_EXT = 0x3007;
        public const GLenum GL_MAX_CULL_DISTANCES_EXT = 0x82F9;
        public const GLenum GL_MAX_COMBINED_CLIP_AND_CULL_DISTANCES_EXT = 0x82FA;
    }
}
#endif