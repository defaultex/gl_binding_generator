#if (GL_ARM_mali_shader_binary && GLES2_API)
public partial class arm { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MALI_SHADER_BINARY_ARM = 0x8F60;
#endif
    }
}
#endif