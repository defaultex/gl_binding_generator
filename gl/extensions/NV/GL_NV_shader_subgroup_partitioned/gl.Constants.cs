#if (GL_NV_shader_subgroup_partitioned && (GL_API || GLCORE_API || GLES2_API))
public partial class nv { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SUBGROUP_FEATURE_PARTITIONED_BIT_NV = 0x00000100;
#endif
    }
}
#endif