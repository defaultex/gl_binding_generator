#if (GL_OES_compressed_paletted_texture && (GL_API || GLES1_API || GLES2_API))
public partial class oes { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PALETTE4_RGB8_OES = 0x8B90;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PALETTE4_RGBA8_OES = 0x8B91;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PALETTE4_R5_G6_B5_OES = 0x8B92;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PALETTE4_RGBA4_OES = 0x8B93;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PALETTE4_RGB5_A1_OES = 0x8B94;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PALETTE8_RGB8_OES = 0x8B95;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PALETTE8_RGBA8_OES = 0x8B96;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PALETTE8_R5_G6_B5_OES = 0x8B97;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PALETTE8_RGBA4_OES = 0x8B98;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PALETTE8_RGB5_A1_OES = 0x8B99;
#endif
    }
}
#endif