#if (GL_NV_non_square_matrices && GLES2_API)
public partial class nv { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_FLOAT_MAT2x3_NV = 0x8B65;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_FLOAT_MAT2x4_NV = 0x8B66;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_FLOAT_MAT3x2_NV = 0x8B67;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_FLOAT_MAT3x4_NV = 0x8B68;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_FLOAT_MAT4x2_NV = 0x8B69;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_FLOAT_MAT4x3_NV = 0x8B6A;
#endif
    }
}
#endif