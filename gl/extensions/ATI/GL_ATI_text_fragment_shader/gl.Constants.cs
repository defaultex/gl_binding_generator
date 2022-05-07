#if (GL_ATI_text_fragment_shader && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_TEXT_FRAGMENT_SHADER_ATI = 0x8200;
    }
}
#endif