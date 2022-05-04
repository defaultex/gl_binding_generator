#if (GL_ATI_text_fragment_shader && GL_API)
public partial class ati { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXT_FRAGMENT_SHADER_ATI = 0x8200;
#endif
    }
}
#endif