#if (GL_ES_VERSION_2_0 && GLES2_API)
public partial class gles2 { 
    public partial class Constants { 

#if !GL_SC_VERSION_2_0
        public const GLenum GL_FRAMEBUFFER_INCOMPLETE_DIMENSIONS = 0x8CD9;
#endif
    }
}
#endif