#if (GL_ATI_texture_env_combine3 && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_MODULATE_ADD_ATI = 0x8744;
        public const GLenum GL_MODULATE_SIGNED_ADD_ATI = 0x8745;
        public const GLenum GL_MODULATE_SUBTRACT_ATI = 0x8746;
    }
}
#endif