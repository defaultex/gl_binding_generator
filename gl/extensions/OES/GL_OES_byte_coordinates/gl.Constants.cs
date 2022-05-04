#if (GL_OES_byte_coordinates && (GL_API || GLES1_API))
public partial class oes { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_BYTE = 0x1400;
#endif
    }
}
#endif