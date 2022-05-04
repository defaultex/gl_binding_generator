#if (GL_EXT_index_func && GL_API)
public partial class ext { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_INDEX_TEST_EXT = 0x81B5;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_INDEX_TEST_FUNC_EXT = 0x81B6;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_INDEX_TEST_REF_EXT = 0x81B7;
#endif
    }
}
#endif