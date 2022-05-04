#if (GL_ARB_indirect_parameters && (GL_API || GLCORE_API))
public partial class arb { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PARAMETER_BUFFER_ARB = 0x80EE;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PARAMETER_BUFFER_BINDING_ARB = 0x80EF;
#endif
    }
}
#endif