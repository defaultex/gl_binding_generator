#if (GL_REND_screen_coordinates && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_SCREEN_COORDINATES_REND = 0x8490;
        public const GLenum GL_INVERTED_SCREEN_W_REND = 0x8491;
    }
}
#endif