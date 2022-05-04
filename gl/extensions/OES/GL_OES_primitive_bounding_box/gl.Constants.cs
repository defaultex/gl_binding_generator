#if (GL_OES_primitive_bounding_box && GLES2_API)
public partial class oes { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PRIMITIVE_BOUNDING_BOX_OES = 0x92BE;
#endif
    }
}
#endif