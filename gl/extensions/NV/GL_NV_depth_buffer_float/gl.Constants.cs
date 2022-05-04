#if (GL_NV_depth_buffer_float && (GL_API || GLCORE_API))
public partial class nv { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_DEPTH_COMPONENT32F_NV = 0x8DAB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_DEPTH32F_STENCIL8_NV = 0x8DAC;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_FLOAT_32_UNSIGNED_INT_24_8_REV_NV = 0x8DAD;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_DEPTH_BUFFER_FLOAT_MODE_NV = 0x8DAF;
#endif
    }
}
#endif