#if (GL_NV_fragment_program2 && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_MAX_PROGRAM_EXEC_INSTRUCTIONS_NV = 0x88F4;
        public const GLenum GL_MAX_PROGRAM_CALL_DEPTH_NV = 0x88F5;
        public const GLenum GL_MAX_PROGRAM_IF_DEPTH_NV = 0x88F6;
        public const GLenum GL_MAX_PROGRAM_LOOP_DEPTH_NV = 0x88F7;
        public const GLenum GL_MAX_PROGRAM_LOOP_COUNT_NV = 0x88F8;
    }
}
#endif