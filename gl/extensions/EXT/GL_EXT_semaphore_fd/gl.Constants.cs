#if (GL_EXT_semaphore_fd && (GL_API || GLES2_API))
public partial class ext { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_HANDLE_TYPE_OPAQUE_FD_EXT = 0x9586;
#endif
    }
}
#endif