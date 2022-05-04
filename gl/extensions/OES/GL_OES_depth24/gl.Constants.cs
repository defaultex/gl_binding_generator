#if (GL_OES_depth24 && (GLES1_API || GLES2_API || GLSC2_API))
public partial class oes { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_DEPTH_COMPONENT24_OES = 0x81A6;
#endif
    }
}
#endif