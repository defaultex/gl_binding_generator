#if (GL_ARB_texture_storage && (GL_API || GLCORE_API))
public partial class arb { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_TEXTURE_IMMUTABLE_FORMAT = 0x912F;
#endif
    }
}
#endif