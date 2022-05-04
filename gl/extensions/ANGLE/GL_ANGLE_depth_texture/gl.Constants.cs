#if (GL_ANGLE_depth_texture && GLES2_API)
public partial class angle { 
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

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_DEPTH_COMPONENT16 = 0x81A5;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_DEPTH_COMPONENT32_OES = 0x81A7;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_DEPTH_STENCIL_OES = 0x84F9;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_UNSIGNED_INT_24_8_OES = 0x84FA;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_DEPTH24_STENCIL8_OES = 0x88F0;
#endif
    }
}
#endif