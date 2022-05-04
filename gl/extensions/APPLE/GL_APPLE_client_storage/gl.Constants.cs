#if (GL_APPLE_client_storage && GL_API)
public partial class apple { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_UNPACK_CLIENT_STORAGE_APPLE = 0x85B2;
#endif
    }
}
#endif