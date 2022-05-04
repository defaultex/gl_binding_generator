#if (GL_ATI_separate_stencil && GL_API)
public partial class ati { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_STENCIL_BACK_FUNC_ATI = 0x8800;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_STENCIL_BACK_FAIL_ATI = 0x8801;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_STENCIL_BACK_PASS_DEPTH_FAIL_ATI = 0x8802;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_STENCIL_BACK_PASS_DEPTH_PASS_ATI = 0x8803;
#endif
    }
}
#endif