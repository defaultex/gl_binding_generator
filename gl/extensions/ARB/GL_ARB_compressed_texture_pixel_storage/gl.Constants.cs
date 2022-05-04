#if (GL_ARB_compressed_texture_pixel_storage && (GL_API || GLCORE_API))
public partial class arb { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_UNPACK_COMPRESSED_BLOCK_WIDTH = 0x9127;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_UNPACK_COMPRESSED_BLOCK_HEIGHT = 0x9128;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_UNPACK_COMPRESSED_BLOCK_DEPTH = 0x9129;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_UNPACK_COMPRESSED_BLOCK_SIZE = 0x912A;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_PACK_COMPRESSED_BLOCK_WIDTH = 0x912B;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_PACK_COMPRESSED_BLOCK_HEIGHT = 0x912C;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_PACK_COMPRESSED_BLOCK_DEPTH = 0x912D;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_PACK_COMPRESSED_BLOCK_SIZE = 0x912E;
#endif
    }
}
#endif