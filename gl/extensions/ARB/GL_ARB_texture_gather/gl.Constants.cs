#if (GL_ARB_texture_gather && (GL_API || GLCORE_API))
public partial class arb { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MIN_PROGRAM_TEXTURE_GATHER_OFFSET_ARB = 0x8E5E;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_PROGRAM_TEXTURE_GATHER_OFFSET_ARB = 0x8E5F;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_PROGRAM_TEXTURE_GATHER_COMPONENTS_ARB = 0x8F9F;
#endif
    }
}
#endif