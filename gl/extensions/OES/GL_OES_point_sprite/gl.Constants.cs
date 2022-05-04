#if (GL_OES_point_sprite && GLES1_API)
public partial class oes { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_POINT_SPRITE_OES = 0x8861;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_COORD_REPLACE_OES = 0x8862;
#endif
    }
}
#endif