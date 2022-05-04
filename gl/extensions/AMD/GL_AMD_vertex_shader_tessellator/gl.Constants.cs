#if (GL_AMD_vertex_shader_tessellator && GL_API)
public partial class amd { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SAMPLER_BUFFER_AMD = 0x9001;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_INT_SAMPLER_BUFFER_AMD = 0x9002;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_UNSIGNED_INT_SAMPLER_BUFFER_AMD = 0x9003;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TESSELLATION_MODE_AMD = 0x9004;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TESSELLATION_FACTOR_AMD = 0x9005;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_DISCRETE_AMD = 0x9006;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_CONTINUOUS_AMD = 0x9007;
#endif
    }
}
#endif