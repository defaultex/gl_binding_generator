#if (GL_NV_point_sprite && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_POINT_SPRITE_NV = 0x8861;
        public const GLenum GL_COORD_REPLACE_NV = 0x8862;
        public const GLenum GL_POINT_SPRITE_R_MODE_NV = 0x8863;
    }
}
#endif