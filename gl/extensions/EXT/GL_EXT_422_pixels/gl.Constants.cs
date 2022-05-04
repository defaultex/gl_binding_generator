#if (GL_EXT_422_pixels && GL_API)
public partial class ext { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_422_EXT = 0x80CC;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_422_REV_EXT = 0x80CD;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_422_AVERAGE_EXT = 0x80CE;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_422_REV_AVERAGE_EXT = 0x80CF;
#endif
    }
}
#endif