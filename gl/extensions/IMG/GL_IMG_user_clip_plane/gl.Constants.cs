#if (GL_IMG_user_clip_plane && !gles1)
public partial class gles1 { 
    public partial class Constants { 
        public const GLenum GL_MAX_CLIP_PLANES_IMG = 0x0D32;
        public const GLenum GL_CLIP_PLANE0_IMG = 0x3000;
        public const GLenum GL_CLIP_PLANE1_IMG = 0x3001;
        public const GLenum GL_CLIP_PLANE2_IMG = 0x3002;
        public const GLenum GL_CLIP_PLANE3_IMG = 0x3003;
        public const GLenum GL_CLIP_PLANE4_IMG = 0x3004;
        public const GLenum GL_CLIP_PLANE5_IMG = 0x3005;
    }
}
#endif