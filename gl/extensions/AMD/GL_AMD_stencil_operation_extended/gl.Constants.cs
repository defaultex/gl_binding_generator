#if (GL_AMD_stencil_operation_extended && GL_API)
public partial class amd { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SET_AMD = 0x874A;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_REPLACE_VALUE_AMD = 0x874B;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_STENCIL_OP_VALUE_AMD = 0x874C;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_STENCIL_BACK_OP_VALUE_AMD = 0x874D;
#endif
    }
}
#endif