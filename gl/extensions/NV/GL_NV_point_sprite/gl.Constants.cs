#if (GL_NV_point_sprite && GL_API)
public partial class nv { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_POINT_SPRITE_NV = 0x8861;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_COORD_REPLACE_NV = 0x8862;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_POINT_SPRITE_R_MODE_NV = 0x8863;
#endif
    }
}
#endif