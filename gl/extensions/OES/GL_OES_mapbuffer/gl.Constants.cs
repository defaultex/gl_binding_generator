#if (GL_OES_mapbuffer && (GLES1_API || GLES2_API))
public partial class glext_oes { 
    public partial class Constants { 
        public const GLenum GL_WRITE_ONLY_OES = 0x88B9;
        public const GLenum GL_BUFFER_ACCESS_OES = 0x88BB;
        public const GLenum GL_BUFFER_MAPPED_OES = 0x88BC;
        public const GLenum GL_BUFFER_MAP_POINTER_OES = 0x88BD;
    }
}
#endif