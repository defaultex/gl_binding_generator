#if (GL_OES_depth_texture && GLES2_API)
public partial class oes { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_UNSIGNED_SHORT = 0x1403;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_UNSIGNED_INT = 0x1405;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_DEPTH_COMPONENT = 0x1902;
#endif
    }
}
#endif