#if (GL_ARB_seamless_cube_map && (GL_API || GLCORE_API))
public partial class arb { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_TEXTURE_CUBE_MAP_SEAMLESS = 0x884F;
#endif
    }
}
#endif