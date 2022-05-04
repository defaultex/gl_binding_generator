#if (GL_OES_fixed_point && (GL_API || GLES1_API))
public partial class oes { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_FIXED_OES = 0x140C;
#endif
    }
}
#endif