#if (GL_OES_matrix_get && GLES1_API)
public partial class oes { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MODELVIEW_MATRIX_FLOAT_AS_INT_BITS_OES = 0x898D;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PROJECTION_MATRIX_FLOAT_AS_INT_BITS_OES = 0x898E;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_MATRIX_FLOAT_AS_INT_BITS_OES = 0x898F;
#endif
    }
}
#endif