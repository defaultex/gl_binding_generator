#if (GL_ARB_depth_buffer_float && (GL_API || GLCORE_API))
public partial class arb { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_DEPTH_COMPONENT32F = 0x8CAC;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_DEPTH32F_STENCIL8 = 0x8CAD;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_FLOAT_32_UNSIGNED_INT_24_8_REV = 0x8DAD;
#endif
    }
}
#endif