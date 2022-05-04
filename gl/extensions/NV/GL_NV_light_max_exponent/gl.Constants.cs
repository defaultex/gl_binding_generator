#if (GL_NV_light_max_exponent && GL_API)
public partial class nv { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_SHININESS_NV = 0x8504;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_SPOT_EXPONENT_NV = 0x8505;
#endif
    }
}
#endif