#if (GL_NV_scissor_exclusive && (GL_API || GLCORE_API || GLES2_API))
public partial class nv { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SCISSOR_TEST_EXCLUSIVE_NV = 0x9555;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SCISSOR_BOX_EXCLUSIVE_NV = 0x9556;
#endif
    }
}
#endif