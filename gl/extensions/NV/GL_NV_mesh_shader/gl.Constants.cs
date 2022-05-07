#if (GL_NV_mesh_shader && (!gl || !glcore || !gles2))
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_MESH_SHADER_BIT_NV = 0x00000040;
        public const GLenum GL_TASK_SHADER_BIT_NV = 0x00000080;
        public const GLenum GL_MAX_MESH_UNIFORM_BLOCKS_NV = 0x8E60;
        public const GLenum GL_MAX_MESH_TEXTURE_IMAGE_UNITS_NV = 0x8E61;
        public const GLenum GL_MAX_MESH_IMAGE_UNIFORMS_NV = 0x8E62;
        public const GLenum GL_MAX_MESH_UNIFORM_COMPONENTS_NV = 0x8E63;
        public const GLenum GL_MAX_MESH_ATOMIC_COUNTER_BUFFERS_NV = 0x8E64;
        public const GLenum GL_MAX_MESH_ATOMIC_COUNTERS_NV = 0x8E65;
        public const GLenum GL_MAX_MESH_SHADER_STORAGE_BLOCKS_NV = 0x8E66;
        public const GLenum GL_MAX_COMBINED_MESH_UNIFORM_COMPONENTS_NV = 0x8E67;
        public const GLenum GL_MAX_TASK_UNIFORM_BLOCKS_NV = 0x8E68;
        public const GLenum GL_MAX_TASK_TEXTURE_IMAGE_UNITS_NV = 0x8E69;
        public const GLenum GL_MAX_TASK_IMAGE_UNIFORMS_NV = 0x8E6A;
        public const GLenum GL_MAX_TASK_UNIFORM_COMPONENTS_NV = 0x8E6B;
        public const GLenum GL_MAX_TASK_ATOMIC_COUNTER_BUFFERS_NV = 0x8E6C;
        public const GLenum GL_MAX_TASK_ATOMIC_COUNTERS_NV = 0x8E6D;
        public const GLenum GL_MAX_TASK_SHADER_STORAGE_BLOCKS_NV = 0x8E6E;
        public const GLenum GL_MAX_COMBINED_TASK_UNIFORM_COMPONENTS_NV = 0x8E6F;
        public const GLenum GL_MESH_OUTPUT_PER_VERTEX_GRANULARITY_NV = 0x92DF;
        public const GLenum GL_MAX_MESH_TOTAL_MEMORY_SIZE_NV = 0x9536;
        public const GLenum GL_MAX_TASK_TOTAL_MEMORY_SIZE_NV = 0x9537;
        public const GLenum GL_MAX_MESH_OUTPUT_VERTICES_NV = 0x9538;
        public const GLenum GL_MAX_MESH_OUTPUT_PRIMITIVES_NV = 0x9539;
        public const GLenum GL_MAX_TASK_OUTPUT_COUNT_NV = 0x953A;
        public const GLenum GL_MAX_MESH_WORK_GROUP_SIZE_NV = 0x953B;
        public const GLenum GL_MAX_TASK_WORK_GROUP_SIZE_NV = 0x953C;
        public const GLenum GL_MAX_DRAW_MESH_TASKS_COUNT_NV = 0x953D;
        public const GLenum GL_MESH_WORK_GROUP_SIZE_NV = 0x953E;
        public const GLenum GL_TASK_WORK_GROUP_SIZE_NV = 0x953F;
        public const GLenum GL_MESH_OUTPUT_PER_PRIMITIVE_GRANULARITY_NV = 0x9543;
        public const GLenum GL_MAX_MESH_VIEWS_NV = 0x9557;
        public const GLenum GL_MESH_SHADER_NV = 0x9559;
        public const GLenum GL_TASK_SHADER_NV = 0x955A;
        public const GLenum GL_MESH_VERTICES_OUT_NV = 0x9579;
        public const GLenum GL_MESH_PRIMITIVES_OUT_NV = 0x957A;
        public const GLenum GL_MESH_OUTPUT_TYPE_NV = 0x957B;
        public const GLenum GL_MESH_SUBROUTINE_NV = 0x957C;
        public const GLenum GL_TASK_SUBROUTINE_NV = 0x957D;
        public const GLenum GL_MESH_SUBROUTINE_UNIFORM_NV = 0x957E;
        public const GLenum GL_TASK_SUBROUTINE_UNIFORM_NV = 0x957F;
        public const GLenum GL_UNIFORM_BLOCK_REFERENCED_BY_MESH_SHADER_NV = 0x959C;
        public const GLenum GL_UNIFORM_BLOCK_REFERENCED_BY_TASK_SHADER_NV = 0x959D;
        public const GLenum GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_MESH_SHADER_NV = 0x959E;
        public const GLenum GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_TASK_SHADER_NV = 0x959F;
        public const GLenum GL_REFERENCED_BY_MESH_SHADER_NV = 0x95A0;
        public const GLenum GL_REFERENCED_BY_TASK_SHADER_NV = 0x95A1;
        public const GLenum GL_MAX_MESH_WORK_GROUP_INVOCATIONS_NV = 0x95A2;
        public const GLenum GL_MAX_TASK_WORK_GROUP_INVOCATIONS_NV = 0x95A3;
    }
}
#endif