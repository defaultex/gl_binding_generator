#if (GL_ARB_seamless_cube_map && (!gl || !glcore))
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_TEXTURE_CUBE_MAP_SEAMLESS = 0x884F;
    }
}
#endif