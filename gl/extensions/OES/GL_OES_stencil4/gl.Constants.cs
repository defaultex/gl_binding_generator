#if (GL_OES_stencil4 && (GLES1_API || GLES2_API))
public partial class oes { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_STENCIL_INDEX4_OES = 0x8D47;
#endif
    }
}
#endif