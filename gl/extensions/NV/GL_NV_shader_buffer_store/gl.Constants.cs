#if (GL_NV_shader_buffer_store && (GL_API || GLCORE_API))
public partial class nv { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SHADER_GLOBAL_ACCESS_BARRIER_BIT_NV = 0x00000010;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_WRITE_ONLY = 0x88B9;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_READ_WRITE = 0x88BA;
#endif
    }
}
#endif