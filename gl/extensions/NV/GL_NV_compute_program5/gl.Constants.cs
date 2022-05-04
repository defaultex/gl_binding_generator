#if (GL_NV_compute_program5 && GL_API)
public partial class nv { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_COMPUTE_PROGRAM_NV = 0x90FB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_COMPUTE_PROGRAM_PARAMETER_BUFFER_NV = 0x90FC;
#endif
    }
}
#endif