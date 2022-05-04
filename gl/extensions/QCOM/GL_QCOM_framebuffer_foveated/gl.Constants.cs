#if (GL_QCOM_framebuffer_foveated && GLES2_API)
public partial class qcom { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_FOVEATION_ENABLE_BIT_QCOM = 0x00000001;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_FOVEATION_SCALED_BIN_METHOD_BIT_QCOM = 0x00000002;
#endif
    }
}
#endif