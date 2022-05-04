#if (GL_OES_surfaceless_context && (GLES1_API || GLES2_API))
public partial class oes { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_FRAMEBUFFER_UNDEFINED_OES = 0x8219;
#endif
    }
}
#endif