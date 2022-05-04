#if (GL_SUNX_constant_data && GL_API)
public partial class sunx { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_UNPACK_CONSTANT_DATA_SUNX = 0x81D5;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_CONSTANT_DATA_SUNX = 0x81D6;
#endif
    }
}
#endif