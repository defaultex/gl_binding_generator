#if (GL_EXT_packed_float && GL_API)
public partial class ext { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_R11F_G11F_B10F_EXT = 0x8C3A;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_UNSIGNED_INT_10F_11F_11F_REV_EXT = 0x8C3B;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_RGBA_SIGNED_COMPONENTS_EXT = 0x8C3C;
#endif
    }
}
#endif