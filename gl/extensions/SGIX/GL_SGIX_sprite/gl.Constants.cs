#if (GL_SGIX_sprite && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_SPRITE_SGIX = 0x8148;
        public const GLenum GL_SPRITE_MODE_SGIX = 0x8149;
        public const GLenum GL_SPRITE_AXIS_SGIX = 0x814A;
        public const GLenum GL_SPRITE_TRANSLATION_SGIX = 0x814B;
        public const GLenum GL_SPRITE_AXIAL_SGIX = 0x814C;
        public const GLenum GL_SPRITE_OBJECT_ALIGNED_SGIX = 0x814D;
        public const GLenum GL_SPRITE_EYE_ALIGNED_SGIX = 0x814E;
    }
}
#endif