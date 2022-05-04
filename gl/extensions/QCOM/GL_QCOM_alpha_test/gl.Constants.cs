#if (GL_QCOM_alpha_test && GLES2_API)
public partial class qcom { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_ALPHA_TEST_QCOM = 0x0BC0;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_ALPHA_TEST_FUNC_QCOM = 0x0BC1;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_ALPHA_TEST_REF_QCOM = 0x0BC2;
#endif
    }
}
#endif