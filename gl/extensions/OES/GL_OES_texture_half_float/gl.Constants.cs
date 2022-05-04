#if (GL_OES_texture_half_float && GLES2_API)
public partial class oes { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_HALF_FLOAT_OES = 0x8D61;
#endif
    }
}
#endif