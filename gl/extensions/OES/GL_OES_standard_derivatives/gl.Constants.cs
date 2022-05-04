#if (GL_OES_standard_derivatives && (GLES2_API || GLSC2_API))
public partial class oes { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_FRAGMENT_SHADER_DERIVATIVE_HINT_OES = 0x8B8B;
#endif
    }
}
#endif