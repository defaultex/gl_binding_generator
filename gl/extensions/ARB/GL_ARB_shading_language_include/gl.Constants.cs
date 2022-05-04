#if (GL_ARB_shading_language_include && (GL_API || GLCORE_API))
public partial class arb { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SHADER_INCLUDE_ARB = 0x8DAE;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_NAMED_STRING_LENGTH_ARB = 0x8DE9;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_NAMED_STRING_TYPE_ARB = 0x8DEA;
#endif
    }
}
#endif