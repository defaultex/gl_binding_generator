#if (GL_OES_point_size_array && GLES1_API)
public partial class oes { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_POINT_SIZE_ARRAY_TYPE_OES = 0x898A;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_POINT_SIZE_ARRAY_STRIDE_OES = 0x898B;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_POINT_SIZE_ARRAY_POINTER_OES = 0x898C;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_POINT_SIZE_ARRAY_OES = 0x8B9C;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_POINT_SIZE_ARRAY_BUFFER_BINDING_OES = 0x8B9F;
#endif
    }
}
#endif