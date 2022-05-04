#if (GL_SGIX_depth_texture && GL_API)
public partial class sgix { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_DEPTH_COMPONENT16_SGIX = 0x81A5;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_DEPTH_COMPONENT24_SGIX = 0x81A6;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_DEPTH_COMPONENT32_SGIX = 0x81A7;
#endif
    }
}
#endif