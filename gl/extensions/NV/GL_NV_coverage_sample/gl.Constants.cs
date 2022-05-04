#if (GL_NV_coverage_sample && GLES2_API)
public partial class nv { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_COVERAGE_BUFFER_BIT_NV = 0x00008000;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_COVERAGE_COMPONENT_NV = 0x8ED0;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_COVERAGE_COMPONENT4_NV = 0x8ED1;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_COVERAGE_ATTACHMENT_NV = 0x8ED2;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_COVERAGE_BUFFERS_NV = 0x8ED3;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_COVERAGE_SAMPLES_NV = 0x8ED4;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_COVERAGE_ALL_FRAGMENTS_NV = 0x8ED5;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_COVERAGE_EDGE_FRAGMENTS_NV = 0x8ED6;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_COVERAGE_AUTOMATIC_NV = 0x8ED7;
#endif
    }
}
#endif