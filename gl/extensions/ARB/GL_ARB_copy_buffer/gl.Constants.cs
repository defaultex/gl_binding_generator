#if (GL_ARB_copy_buffer && (GL_API || GLCORE_API))
public partial class arb { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_COPY_READ_BUFFER = 0x8F36;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_COPY_WRITE_BUFFER = 0x8F37;
#endif
    }
}
#endif