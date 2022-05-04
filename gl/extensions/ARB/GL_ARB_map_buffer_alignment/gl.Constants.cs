#if (GL_ARB_map_buffer_alignment && (GL_API || GLCORE_API))
public partial class arb { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_MIN_MAP_BUFFER_ALIGNMENT = 0x90BC;
#endif
    }
}
#endif