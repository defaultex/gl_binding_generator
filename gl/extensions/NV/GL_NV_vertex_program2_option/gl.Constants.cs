#if (GL_NV_vertex_program2_option && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_MAX_PROGRAM_EXEC_INSTRUCTIONS_NV = 0x88F4;
        public const GLenum GL_MAX_PROGRAM_CALL_DEPTH_NV = 0x88F5;
    }
}
#endif