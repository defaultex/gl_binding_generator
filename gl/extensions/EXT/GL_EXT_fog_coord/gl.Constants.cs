#if (GL_EXT_fog_coord && GL_API)
public partial class ext { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_FOG_COORDINATE_SOURCE_EXT = 0x8450;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_FOG_COORDINATE_EXT = 0x8451;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_FRAGMENT_DEPTH_EXT = 0x8452;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_CURRENT_FOG_COORDINATE_EXT = 0x8453;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_FOG_COORDINATE_ARRAY_TYPE_EXT = 0x8454;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_FOG_COORDINATE_ARRAY_STRIDE_EXT = 0x8455;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_FOG_COORDINATE_ARRAY_POINTER_EXT = 0x8456;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_FOG_COORDINATE_ARRAY_EXT = 0x8457;
#endif
    }
}
#endif