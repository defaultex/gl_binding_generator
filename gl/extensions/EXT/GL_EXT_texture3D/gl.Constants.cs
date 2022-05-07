#if (GL_EXT_texture3D && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_PACK_SKIP_IMAGES_EXT = 0x806B;
        public const GLenum GL_PACK_IMAGE_HEIGHT_EXT = 0x806C;
        public const GLenum GL_UNPACK_SKIP_IMAGES_EXT = 0x806D;
        public const GLenum GL_UNPACK_IMAGE_HEIGHT_EXT = 0x806E;
        public const GLenum GL_TEXTURE_3D_EXT = 0x806F;
        public const GLenum GL_PROXY_TEXTURE_3D_EXT = 0x8070;
        public const GLenum GL_TEXTURE_DEPTH_EXT = 0x8071;
        public const GLenum GL_TEXTURE_WRAP_R_EXT = 0x8072;
        public const GLenum GL_MAX_3D_TEXTURE_SIZE_EXT = 0x8073;
    }
}
#endif