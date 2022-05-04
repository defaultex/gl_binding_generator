#if (GL_NV_texgen_reflection && GL_API)
public partial class nv { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_NORMAL_MAP_NV = 0x8511;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_REFLECTION_MAP_NV = 0x8512;
#endif
    }
}
#endif