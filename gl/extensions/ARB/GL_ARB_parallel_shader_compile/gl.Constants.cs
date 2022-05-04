#if (GL_ARB_parallel_shader_compile && (GL_API || GLCORE_API))
public partial class arb { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_SHADER_COMPILER_THREADS_ARB = 0x91B0;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_COMPLETION_STATUS_ARB = 0x91B1;
#endif
    }
}
#endif