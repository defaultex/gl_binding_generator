#if (GL_APPLE_texture_packed_float && GLES2_API)
public partial class apple { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_R11F_G11F_B10F_APPLE = 0x8C3A;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_UNSIGNED_INT_10F_11F_11F_REV_APPLE = 0x8C3B;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_RGB9_E5_APPLE = 0x8C3D;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_UNSIGNED_INT_5_9_9_9_REV_APPLE = 0x8C3E;
#endif
    }
}
#endif