#if (GL_NV_shader_buffer_load && (GL_API || GLCORE_API))
public partial class nv { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_BUFFER_GPU_ADDRESS_NV = 0x8F1D;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_GPU_ADDRESS_NV = 0x8F34;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_SHADER_BUFFER_ADDRESS_NV = 0x8F35;
#endif
    }
}
#endif