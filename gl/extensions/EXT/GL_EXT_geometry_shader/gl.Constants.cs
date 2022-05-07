#if (GL_EXT_geometry_shader && !gles2)
public partial class gles2 { 
    public partial class Constants { 
        public const GLenum GL_GEOMETRY_SHADER_BIT_EXT = 0x00000004;
        public const GLenum GL_LINES_ADJACENCY_EXT = 0x000A;
        public const GLenum GL_LINE_STRIP_ADJACENCY_EXT = 0x000B;
        public const GLenum GL_TRIANGLES_ADJACENCY_EXT = 0x000C;
        public const GLenum GL_TRIANGLE_STRIP_ADJACENCY_EXT = 0x000D;
        public const GLenum GL_LAYER_PROVOKING_VERTEX_EXT = 0x825E;
        public const GLenum GL_UNDEFINED_VERTEX_EXT = 0x8260;
        public const GLenum GL_GEOMETRY_SHADER_INVOCATIONS_EXT = 0x887F;
        public const GLenum GL_GEOMETRY_LINKED_VERTICES_OUT_EXT = 0x8916;
        public const GLenum GL_GEOMETRY_LINKED_INPUT_TYPE_EXT = 0x8917;
        public const GLenum GL_GEOMETRY_LINKED_OUTPUT_TYPE_EXT = 0x8918;
        public const GLenum GL_MAX_GEOMETRY_UNIFORM_BLOCKS_EXT = 0x8A2C;
        public const GLenum GL_MAX_COMBINED_GEOMETRY_UNIFORM_COMPONENTS_EXT = 0x8A32;
        public const GLenum GL_MAX_GEOMETRY_TEXTURE_IMAGE_UNITS_EXT = 0x8C29;
        public const GLenum GL_PRIMITIVES_GENERATED_EXT = 0x8C87;
        public const GLenum GL_FRAMEBUFFER_ATTACHMENT_LAYERED_EXT = 0x8DA7;
        public const GLenum GL_FRAMEBUFFER_INCOMPLETE_LAYER_TARGETS_EXT = 0x8DA8;
        public const GLenum GL_GEOMETRY_SHADER_EXT = 0x8DD9;
        public const GLenum GL_MAX_GEOMETRY_UNIFORM_COMPONENTS_EXT = 0x8DDF;
        public const GLenum GL_MAX_GEOMETRY_OUTPUT_VERTICES_EXT = 0x8DE0;
        public const GLenum GL_MAX_GEOMETRY_TOTAL_OUTPUT_COMPONENTS_EXT = 0x8DE1;
        public const GLenum GL_FIRST_VERTEX_CONVENTION_EXT = 0x8E4D;
        public const GLenum GL_LAST_VERTEX_CONVENTION_EXT = 0x8E4E;
        public const GLenum GL_MAX_GEOMETRY_SHADER_INVOCATIONS_EXT = 0x8E5A;
        public const GLenum GL_MAX_GEOMETRY_IMAGE_UNIFORMS_EXT = 0x90CD;
        public const GLenum GL_MAX_GEOMETRY_SHADER_STORAGE_BLOCKS_EXT = 0x90D7;
        public const GLenum GL_MAX_GEOMETRY_INPUT_COMPONENTS_EXT = 0x9123;
        public const GLenum GL_MAX_GEOMETRY_OUTPUT_COMPONENTS_EXT = 0x9124;
        public const GLenum GL_MAX_GEOMETRY_ATOMIC_COUNTER_BUFFERS_EXT = 0x92CF;
        public const GLenum GL_MAX_GEOMETRY_ATOMIC_COUNTERS_EXT = 0x92D5;
        public const GLenum GL_REFERENCED_BY_GEOMETRY_SHADER_EXT = 0x9309;
        public const GLenum GL_FRAMEBUFFER_DEFAULT_LAYERS_EXT = 0x9312;
        public const GLenum GL_MAX_FRAMEBUFFER_LAYERS_EXT = 0x9317;
    }
}
#endif