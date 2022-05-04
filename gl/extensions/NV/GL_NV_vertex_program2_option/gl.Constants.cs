#if (GL_NV_vertex_program2_option && GL_API)
public partial class nv { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_PROGRAM_EXEC_INSTRUCTIONS_NV = 0x88F4;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_PROGRAM_CALL_DEPTH_NV = 0x88F5;
#endif
    }
}
#endif