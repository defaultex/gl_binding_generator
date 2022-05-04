#if (GL_APPLE_object_purgeable && GL_API)
public partial class apple { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_BUFFER_OBJECT_APPLE = 0x85B3;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_RELEASED_APPLE = 0x8A19;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_VOLATILE_APPLE = 0x8A1A;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_RETAINED_APPLE = 0x8A1B;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_UNDEFINED_APPLE = 0x8A1C;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PURGEABLE_APPLE = 0x8A1D;
#endif
    }
}
#endif