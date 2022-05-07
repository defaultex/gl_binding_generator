#if (GL_ATI_meminfo && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_VBO_FREE_MEMORY_ATI = 0x87FB;
        public const GLenum GL_TEXTURE_FREE_MEMORY_ATI = 0x87FC;
        public const GLenum GL_RENDERBUFFER_FREE_MEMORY_ATI = 0x87FD;
    }
}
#endif