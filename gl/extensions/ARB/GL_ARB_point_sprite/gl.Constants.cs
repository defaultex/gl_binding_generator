#if (GL_ARB_point_sprite && GL_API)
public partial class arb { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_POINT_SPRITE_ARB = 0x8861;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_COORD_REPLACE_ARB = 0x8862;
#endif
    }
}
#endif