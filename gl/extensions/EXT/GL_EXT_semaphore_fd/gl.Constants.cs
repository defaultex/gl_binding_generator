#if (GL_EXT_semaphore_fd && (!gl || !gles2))
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_HANDLE_TYPE_OPAQUE_FD_EXT = 0x9586;
    }
}
#endif