#if (GL_IBM_texture_mirrored_repeat && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_MIRRORED_REPEAT_IBM = 0x8370;
    }
}
#endif