#if (GL_OES_required_internalformat && (GLES1_API || GLES2_API))
public partial class oes { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_ALPHA8_OES = 0x803C;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_LUMINANCE8_OES = 0x8040;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_LUMINANCE4_ALPHA4_OES = 0x8043;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_LUMINANCE8_ALPHA8_OES = 0x8045;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_RGB8_OES = 0x8051;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_RGB10_EXT = 0x8052;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_RGBA4_OES = 0x8056;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_RGB5_A1_OES = 0x8057;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_RGBA8_OES = 0x8058;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_RGB10_A2_EXT = 0x8059;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_DEPTH_COMPONENT16_OES = 0x81A5;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_DEPTH_COMPONENT24_OES = 0x81A6;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_DEPTH_COMPONENT32_OES = 0x81A7;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_DEPTH24_STENCIL8_OES = 0x88F0;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_RGB565_OES = 0x8D62;
#endif
    }
}
#endif