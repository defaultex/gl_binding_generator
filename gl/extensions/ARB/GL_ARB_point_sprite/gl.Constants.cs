#if (GL_ARB_point_sprite && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_POINT_SPRITE_ARB = 0x8861;
        public const GLenum GL_COORD_REPLACE_ARB = 0x8862;
    }
}
#endif