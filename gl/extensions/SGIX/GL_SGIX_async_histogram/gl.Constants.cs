#if (GL_SGIX_async_histogram && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_ASYNC_HISTOGRAM_SGIX = 0x832C;
        public const GLenum GL_MAX_ASYNC_HISTOGRAM_SGIX = 0x832D;
    }
}
#endif