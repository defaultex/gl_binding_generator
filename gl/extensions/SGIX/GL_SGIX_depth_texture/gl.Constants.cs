#if (GL_SGIX_depth_texture && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_DEPTH_COMPONENT16_SGIX = 0x81A5;
        public const GLenum GL_DEPTH_COMPONENT24_SGIX = 0x81A6;
        public const GLenum GL_DEPTH_COMPONENT32_SGIX = 0x81A7;
    }
}
#endif