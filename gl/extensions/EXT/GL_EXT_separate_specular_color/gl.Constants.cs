#if (GL_EXT_separate_specular_color && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_LIGHT_MODEL_COLOR_CONTROL_EXT = 0x81F8;
        public const GLenum GL_SINGLE_COLOR_EXT = 0x81F9;
        public const GLenum GL_SEPARATE_SPECULAR_COLOR_EXT = 0x81FA;
    }
}
#endif