#if (GL_EXT_primitive_bounding_box && GLES2_API)
public partial class ext { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PRIMITIVE_BOUNDING_BOX_EXT = 0x92BE;
#endif
    }
}
#endif