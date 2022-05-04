#if (GL_KHR_no_error && (GL_API || GLCORE_API || GLES2_API))
public partial class khr { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_CONTEXT_FLAG_NO_ERROR_BIT_KHR = 0x00000008;
#endif
    }
}
#endif