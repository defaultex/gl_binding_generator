#if (GL_ARB_get_program_binary && (GL_API || GLCORE_API))
public partial class arb { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_PROGRAM_BINARY_RETRIEVABLE_HINT = 0x8257;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_PROGRAM_BINARY_LENGTH = 0x8741;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_NUM_PROGRAM_BINARY_FORMATS = 0x87FE;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_PROGRAM_BINARY_FORMATS = 0x87FF;
#endif
    }
}
#endif