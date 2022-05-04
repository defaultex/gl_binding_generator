#if (GL_APPLE_element_array && GL_API)
public partial class apple { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_ELEMENT_ARRAY_APPLE = 0x8A0C;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_ELEMENT_ARRAY_TYPE_APPLE = 0x8A0D;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_ELEMENT_ARRAY_POINTER_APPLE = 0x8A0E;
#endif
    }
}
#endif