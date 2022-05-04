#if (GL_REND_screen_coordinates && GL_API)
public partial class rend { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SCREEN_COORDINATES_REND = 0x8490;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_INVERTED_SCREEN_W_REND = 0x8491;
#endif
    }
}
#endif