#if (GL_EXT_light_texture && GL_API)
public partial class ext { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_FRAGMENT_MATERIAL_EXT = 0x8349;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_FRAGMENT_NORMAL_EXT = 0x834A;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_FRAGMENT_COLOR_EXT = 0x834C;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_ATTENUATION_EXT = 0x834D;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SHADOW_ATTENUATION_EXT = 0x834E;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_APPLICATION_MODE_EXT = 0x834F;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_LIGHT_EXT = 0x8350;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_MATERIAL_FACE_EXT = 0x8351;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_MATERIAL_PARAMETER_EXT = 0x8352;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_FRAGMENT_DEPTH_EXT = 0x8452;
#endif
    }
}
#endif