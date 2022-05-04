#if (GL_HP_occlusion_test && GL_API)
public partial class hp { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_OCCLUSION_TEST_HP = 0x8165;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_OCCLUSION_TEST_RESULT_HP = 0x8166;
#endif
    }
}
#endif