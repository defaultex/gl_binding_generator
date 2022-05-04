#if (GL_EXT_debug_label && (GL_API || GLCORE_API || GLES2_API))
public partial class ext { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_SAMPLER = 0x82E6;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PROGRAM_PIPELINE_OBJECT_EXT = 0x8A4F;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PROGRAM_OBJECT_EXT = 0x8B40;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SHADER_OBJECT_EXT = 0x8B48;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_TRANSFORM_FEEDBACK = 0x8E22;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_BUFFER_OBJECT_EXT = 0x9151;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_QUERY_OBJECT_EXT = 0x9153;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_VERTEX_ARRAY_OBJECT_EXT = 0x9154;
#endif
    }
}
#endif