#if (GL_NV_texture_env_combine4 && GL_API)
public partial class nv { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_COMBINE4_NV = 0x8503;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SOURCE3_RGB_NV = 0x8583;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SOURCE3_ALPHA_NV = 0x858B;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_OPERAND3_RGB_NV = 0x8593;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_OPERAND3_ALPHA_NV = 0x859B;
#endif
    }
}
#endif