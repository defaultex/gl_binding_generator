#if (GL_OES_sample_shading && GLES2_API)
public partial class oes { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SAMPLE_SHADING_OES = 0x8C36;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MIN_SAMPLE_SHADING_VALUE_OES = 0x8C37;
#endif
    }
}
#endif