#if (GL_NV_fragment_program2 && GL_API)
public partial class nv { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_PROGRAM_EXEC_INSTRUCTIONS_NV = 0x88F4;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_PROGRAM_CALL_DEPTH_NV = 0x88F5;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_PROGRAM_IF_DEPTH_NV = 0x88F6;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_PROGRAM_LOOP_DEPTH_NV = 0x88F7;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_PROGRAM_LOOP_COUNT_NV = 0x88F8;
#endif
    }
}
#endif