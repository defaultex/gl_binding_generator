#if (GL_APPLE_client_storage && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_UNPACK_CLIENT_STORAGE_APPLE = 0x85B2;
    }
}
#endif