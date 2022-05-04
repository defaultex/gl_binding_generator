#if (GL_ATI_element_array && GL_API)
public partial class ati { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_ELEMENT_ARRAY_ATI = 0x8768;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_ELEMENT_ARRAY_TYPE_ATI = 0x8769;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_ELEMENT_ARRAY_POINTER_ATI = 0x876A;
#endif
    }
}
#endif