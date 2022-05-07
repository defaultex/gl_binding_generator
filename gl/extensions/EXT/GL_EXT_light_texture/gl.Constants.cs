#if (GL_EXT_light_texture && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_FRAGMENT_MATERIAL_EXT = 0x8349;
        public const GLenum GL_FRAGMENT_NORMAL_EXT = 0x834A;
        public const GLenum GL_FRAGMENT_COLOR_EXT = 0x834C;
        public const GLenum GL_ATTENUATION_EXT = 0x834D;
        public const GLenum GL_SHADOW_ATTENUATION_EXT = 0x834E;
        public const GLenum GL_TEXTURE_APPLICATION_MODE_EXT = 0x834F;
        public const GLenum GL_TEXTURE_LIGHT_EXT = 0x8350;
        public const GLenum GL_TEXTURE_MATERIAL_FACE_EXT = 0x8351;
        public const GLenum GL_TEXTURE_MATERIAL_PARAMETER_EXT = 0x8352;
        public const GLenum GL_FRAGMENT_DEPTH_EXT = 0x8452;
    }
}
#endif