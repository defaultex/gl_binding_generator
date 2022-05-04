#if (GL_ARB_gpu_shader5 && (GL_API || GLCORE_API))
public partial class arb { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_GEOMETRY_SHADER_INVOCATIONS = 0x887F;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_GEOMETRY_SHADER_INVOCATIONS = 0x8E5A;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_MIN_FRAGMENT_INTERPOLATION_OFFSET = 0x8E5B;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_FRAGMENT_INTERPOLATION_OFFSET = 0x8E5C;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLbitfield GL_FRAGMENT_INTERPOLATION_OFFSET_BITS = 0x8E5D;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_VERTEX_STREAMS = 0x8E71;
#endif
    }
}
#endif