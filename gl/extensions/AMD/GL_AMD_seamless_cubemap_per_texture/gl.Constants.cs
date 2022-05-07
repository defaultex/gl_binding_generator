#if (GL_AMD_seamless_cubemap_per_texture && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_TEXTURE_CUBE_MAP_SEAMLESS = 0x884F;
    }
}
#endif