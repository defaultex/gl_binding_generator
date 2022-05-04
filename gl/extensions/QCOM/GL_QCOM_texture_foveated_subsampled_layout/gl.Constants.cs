#if (GL_QCOM_texture_foveated_subsampled_layout && GLES2_API)
public partial class qcom { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_FOVEATION_SUBSAMPLED_LAYOUT_METHOD_BIT_QCOM = 0x00000004;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_SHADER_SUBSAMPLED_IMAGE_UNITS_QCOM = 0x8FA1;
#endif
    }
}
#endif