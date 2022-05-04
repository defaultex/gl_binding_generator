#if (GL_ARB_depth_texture && GL_API)
public partial class arb { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_DEPTH_COMPONENT16_ARB = 0x81A5;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_DEPTH_COMPONENT24_ARB = 0x81A6;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_DEPTH_COMPONENT32_ARB = 0x81A7;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_DEPTH_SIZE_ARB = 0x884A;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_DEPTH_TEXTURE_MODE_ARB = 0x884B;
#endif
    }
}
#endif