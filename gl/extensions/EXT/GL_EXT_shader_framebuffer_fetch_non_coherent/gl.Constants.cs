#if (GL_EXT_shader_framebuffer_fetch_non_coherent && (GL_API || GLCORE_API || GLES2_API))
public partial class ext { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_FRAGMENT_SHADER_DISCARDS_SAMPLES_EXT = 0x8A52;
#endif
    }
}
#endif