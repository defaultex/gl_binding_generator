#if (GL_ARM_texture_unnormalized_coordinates && GLES2_API)
public partial class arm { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_UNNORMALIZED_COORDINATES_ARM = 0x8F6A;
#endif
    }
}
#endif