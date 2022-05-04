#if (GL_NV_parameter_buffer_object && GL_API)
public partial class nv { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_PROGRAM_PARAMETER_BUFFER_BINDINGS_NV = 0x8DA0;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_PROGRAM_PARAMETER_BUFFER_SIZE_NV = 0x8DA1;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_VERTEX_PROGRAM_PARAMETER_BUFFER_NV = 0x8DA2;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_GEOMETRY_PROGRAM_PARAMETER_BUFFER_NV = 0x8DA3;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_FRAGMENT_PROGRAM_PARAMETER_BUFFER_NV = 0x8DA4;
#endif
    }
}
#endif