#if (GL_AMD_program_binary_Z400 && GLES2_API)
public partial class amd { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_Z400_BINARY_AMD = 0x8740;
#endif
    }
}
#endif