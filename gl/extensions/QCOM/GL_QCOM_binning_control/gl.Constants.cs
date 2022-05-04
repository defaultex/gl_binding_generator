#if (GL_QCOM_binning_control && GLES2_API)
public partial class qcom { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_BINNING_CONTROL_HINT_QCOM = 0x8FB0;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_CPU_OPTIMIZED_QCOM = 0x8FB1;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_GPU_OPTIMIZED_QCOM = 0x8FB2;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_RENDER_DIRECT_TO_FRAMEBUFFER_QCOM = 0x8FB3;
#endif
    }
}
#endif