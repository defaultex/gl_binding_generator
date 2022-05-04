#if (GL_NV_pixel_data_range && GL_API)
public partial class nv { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_WRITE_PIXEL_DATA_RANGE_NV = 0x8878;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_READ_PIXEL_DATA_RANGE_NV = 0x8879;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_WRITE_PIXEL_DATA_RANGE_LENGTH_NV = 0x887A;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_READ_PIXEL_DATA_RANGE_LENGTH_NV = 0x887B;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_WRITE_PIXEL_DATA_RANGE_POINTER_NV = 0x887C;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_READ_PIXEL_DATA_RANGE_POINTER_NV = 0x887D;
#endif
    }
}
#endif