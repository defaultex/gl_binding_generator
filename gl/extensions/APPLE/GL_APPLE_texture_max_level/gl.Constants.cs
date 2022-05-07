#if (GL_APPLE_texture_max_level && (!gles1 || !gles2))
public partial class gles1 { 
    public partial class Constants { 
        public const GLenum GL_TEXTURE_MAX_LEVEL_APPLE = 0x813D;
    }
}
#endif