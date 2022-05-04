#if (GL_NV_uniform_buffer_unified_memory && (GL_API || GLCORE_API))
public partial class nv { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_UNIFORM_BUFFER_UNIFIED_NV = 0x936E;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_UNIFORM_BUFFER_ADDRESS_NV = 0x936F;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_UNIFORM_BUFFER_LENGTH_NV = 0x9370;
#endif
    }
}
#endif