#if (GL_ARB_texture_compression_rgtc && (GL_API || GLCORE_API))
public partial class arb { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_COMPRESSED_RED_RGTC1 = 0x8DBB;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_COMPRESSED_SIGNED_RED_RGTC1 = 0x8DBC;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_COMPRESSED_RG_RGTC2 = 0x8DBD;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_COMPRESSED_SIGNED_RG_RGTC2 = 0x8DBE;
#endif
    }
}
#endif