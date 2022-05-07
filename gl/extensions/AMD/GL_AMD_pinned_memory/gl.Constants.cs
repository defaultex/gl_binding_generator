#if (GL_AMD_pinned_memory && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_EXTERNAL_VIRTUAL_MEMORY_BUFFER_AMD = 0x9160;
    }
}
#endif