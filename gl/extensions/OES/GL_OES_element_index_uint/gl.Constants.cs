#if (GL_OES_element_index_uint && (GLES1_API || GLES2_API))
public partial class oes { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_UNSIGNED_INT = 0x1405;
#endif
    }
}
#endif