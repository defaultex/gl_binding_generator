#if (GL_SGIX_async_pixel && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_ASYNC_TEX_IMAGE_SGIX = 0x835C;
        public const GLenum GL_ASYNC_DRAW_PIXELS_SGIX = 0x835D;
        public const GLenum GL_ASYNC_READ_PIXELS_SGIX = 0x835E;
        public const GLenum GL_MAX_ASYNC_TEX_IMAGE_SGIX = 0x835F;
        public const GLenum GL_MAX_ASYNC_DRAW_PIXELS_SGIX = 0x8360;
        public const GLenum GL_MAX_ASYNC_READ_PIXELS_SGIX = 0x8361;
    }
}
#endif