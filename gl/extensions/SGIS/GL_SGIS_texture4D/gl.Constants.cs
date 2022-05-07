#if (GL_SGIS_texture4D && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_PACK_SKIP_VOLUMES_SGIS = 0x8130;
        public const GLenum GL_PACK_IMAGE_DEPTH_SGIS = 0x8131;
        public const GLenum GL_UNPACK_SKIP_VOLUMES_SGIS = 0x8132;
        public const GLenum GL_UNPACK_IMAGE_DEPTH_SGIS = 0x8133;
        public const GLenum GL_TEXTURE_4D_SGIS = 0x8134;
        public const GLenum GL_PROXY_TEXTURE_4D_SGIS = 0x8135;
        public const GLenum GL_TEXTURE_4DSIZE_SGIS = 0x8136;
        public const GLenum GL_TEXTURE_WRAP_Q_SGIS = 0x8137;
        public const GLenum GL_MAX_4D_TEXTURE_SIZE_SGIS = 0x8138;
        public const GLenum GL_TEXTURE_4D_BINDING_SGIS = 0x814F;
    }
}
#endif