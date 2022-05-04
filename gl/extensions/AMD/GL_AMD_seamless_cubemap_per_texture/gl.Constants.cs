#if (GL_AMD_seamless_cubemap_per_texture && GL_API)
public partial class amd { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_TEXTURE_CUBE_MAP_SEAMLESS = 0x884F;
#endif
    }
}
#endif