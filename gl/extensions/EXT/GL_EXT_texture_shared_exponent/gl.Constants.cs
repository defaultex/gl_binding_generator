#if (GL_EXT_texture_shared_exponent && GL_API)
public partial class ext { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_RGB9_E5_EXT = 0x8C3D;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_UNSIGNED_INT_5_9_9_9_REV_EXT = 0x8C3E;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_SHARED_SIZE_EXT = 0x8C3F;
#endif
    }
}
#endif