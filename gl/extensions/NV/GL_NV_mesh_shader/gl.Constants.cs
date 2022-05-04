#if (GL_NV_mesh_shader && (GL_API || GLCORE_API || GLES2_API))
public partial class nv { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MESH_SHADER_BIT_NV = 0x00000040;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TASK_SHADER_BIT_NV = 0x00000080;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_MESH_UNIFORM_BLOCKS_NV = 0x8E60;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_MESH_TEXTURE_IMAGE_UNITS_NV = 0x8E61;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_MESH_IMAGE_UNIFORMS_NV = 0x8E62;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_MESH_UNIFORM_COMPONENTS_NV = 0x8E63;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_MESH_ATOMIC_COUNTER_BUFFERS_NV = 0x8E64;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_MESH_ATOMIC_COUNTERS_NV = 0x8E65;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_MESH_SHADER_STORAGE_BLOCKS_NV = 0x8E66;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_COMBINED_MESH_UNIFORM_COMPONENTS_NV = 0x8E67;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_TASK_UNIFORM_BLOCKS_NV = 0x8E68;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_TASK_TEXTURE_IMAGE_UNITS_NV = 0x8E69;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_TASK_IMAGE_UNIFORMS_NV = 0x8E6A;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_TASK_UNIFORM_COMPONENTS_NV = 0x8E6B;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_TASK_ATOMIC_COUNTER_BUFFERS_NV = 0x8E6C;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_TASK_ATOMIC_COUNTERS_NV = 0x8E6D;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_TASK_SHADER_STORAGE_BLOCKS_NV = 0x8E6E;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_COMBINED_TASK_UNIFORM_COMPONENTS_NV = 0x8E6F;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MESH_OUTPUT_PER_VERTEX_GRANULARITY_NV = 0x92DF;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_MESH_TOTAL_MEMORY_SIZE_NV = 0x9536;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_TASK_TOTAL_MEMORY_SIZE_NV = 0x9537;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_MESH_OUTPUT_VERTICES_NV = 0x9538;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_MESH_OUTPUT_PRIMITIVES_NV = 0x9539;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_TASK_OUTPUT_COUNT_NV = 0x953A;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_MESH_WORK_GROUP_SIZE_NV = 0x953B;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_TASK_WORK_GROUP_SIZE_NV = 0x953C;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_DRAW_MESH_TASKS_COUNT_NV = 0x953D;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MESH_WORK_GROUP_SIZE_NV = 0x953E;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TASK_WORK_GROUP_SIZE_NV = 0x953F;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MESH_OUTPUT_PER_PRIMITIVE_GRANULARITY_NV = 0x9543;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_MESH_VIEWS_NV = 0x9557;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MESH_SHADER_NV = 0x9559;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TASK_SHADER_NV = 0x955A;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MESH_VERTICES_OUT_NV = 0x9579;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MESH_PRIMITIVES_OUT_NV = 0x957A;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MESH_OUTPUT_TYPE_NV = 0x957B;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MESH_SUBROUTINE_NV = 0x957C;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TASK_SUBROUTINE_NV = 0x957D;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MESH_SUBROUTINE_UNIFORM_NV = 0x957E;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TASK_SUBROUTINE_UNIFORM_NV = 0x957F;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_UNIFORM_BLOCK_REFERENCED_BY_MESH_SHADER_NV = 0x959C;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_UNIFORM_BLOCK_REFERENCED_BY_TASK_SHADER_NV = 0x959D;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_MESH_SHADER_NV = 0x959E;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_TASK_SHADER_NV = 0x959F;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_REFERENCED_BY_MESH_SHADER_NV = 0x95A0;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_REFERENCED_BY_TASK_SHADER_NV = 0x95A1;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_MESH_WORK_GROUP_INVOCATIONS_NV = 0x95A2;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_TASK_WORK_GROUP_INVOCATIONS_NV = 0x95A3;
#endif
    }
}
#endif