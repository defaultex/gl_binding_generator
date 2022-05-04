#if (GL_KHR_parallel_shader_compile && (GL_API || GLCORE_API || GLES2_API))
public partial class khr { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_SHADER_COMPILER_THREADS_KHR = 0x91B0;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_COMPLETION_STATUS_KHR = 0x91B1;
#endif
    }
}
#endif