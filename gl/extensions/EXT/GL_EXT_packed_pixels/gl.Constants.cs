#if (GL_EXT_packed_pixels && GL_API)
public partial class ext { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_UNSIGNED_BYTE_3_3_2_EXT = 0x8032;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_UNSIGNED_SHORT_4_4_4_4_EXT = 0x8033;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_UNSIGNED_SHORT_5_5_5_1_EXT = 0x8034;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_UNSIGNED_INT_8_8_8_8_EXT = 0x8035;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_UNSIGNED_INT_10_10_10_2_EXT = 0x8036;
#endif
    }
}
#endif