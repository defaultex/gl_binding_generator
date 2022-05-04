#if (GL_NV_geometry_program4 && GL_API)
public partial class nv { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_LINES_ADJACENCY_EXT = 0x000A;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_LINE_STRIP_ADJACENCY_EXT = 0x000B;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TRIANGLES_ADJACENCY_EXT = 0x000C;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TRIANGLE_STRIP_ADJACENCY_EXT = 0x000D;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PROGRAM_POINT_SIZE_EXT = 0x8642;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_GEOMETRY_PROGRAM_NV = 0x8C26;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_PROGRAM_OUTPUT_VERTICES_NV = 0x8C27;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_PROGRAM_TOTAL_OUTPUT_COMPONENTS_NV = 0x8C28;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_GEOMETRY_TEXTURE_IMAGE_UNITS_EXT = 0x8C29;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LAYER_EXT = 0x8CD4;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_FRAMEBUFFER_ATTACHMENT_LAYERED_EXT = 0x8DA7;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_FRAMEBUFFER_INCOMPLETE_LAYER_TARGETS_EXT = 0x8DA8;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_FRAMEBUFFER_INCOMPLETE_LAYER_COUNT_EXT = 0x8DA9;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_GEOMETRY_VERTICES_OUT_EXT = 0x8DDA;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_GEOMETRY_INPUT_TYPE_EXT = 0x8DDB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_GEOMETRY_OUTPUT_TYPE_EXT = 0x8DDC;
#endif
    }
}
#endif