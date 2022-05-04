#if (GL_DMP_program_binary && GLES2_API)
public partial class dmp { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SMAPHS30_PROGRAM_BINARY_DMP = 0x9251;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SMAPHS_PROGRAM_BINARY_DMP = 0x9252;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_DMP_PROGRAM_BINARY_DMP = 0x9253;
#endif
    }
}
#endif