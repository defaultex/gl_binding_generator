#if (GL_EXT_texture_compression_rgtc && (GL_API || GLES2_API))
public partial class ext { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_COMPRESSED_RED_RGTC1_EXT = 0x8DBB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_COMPRESSED_SIGNED_RED_RGTC1_EXT = 0x8DBC;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_COMPRESSED_RED_GREEN_RGTC2_EXT = 0x8DBD;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_COMPRESSED_SIGNED_RED_GREEN_RGTC2_EXT = 0x8DBE;
#endif
    }
}
#endif