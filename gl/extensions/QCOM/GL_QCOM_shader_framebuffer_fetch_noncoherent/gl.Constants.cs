#if (GL_QCOM_shader_framebuffer_fetch_noncoherent && GLES2_API)
public partial class qcom { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_FRAMEBUFFER_FETCH_NONCOHERENT_QCOM = 0x96A2;
#endif
    }
}
#endif