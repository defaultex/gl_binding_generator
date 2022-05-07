#if (GL_EXT_coordinate_frame && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_TANGENT_ARRAY_EXT = 0x8439;
        public const GLenum GL_BINORMAL_ARRAY_EXT = 0x843A;
        public const GLenum GL_CURRENT_TANGENT_EXT = 0x843B;
        public const GLenum GL_CURRENT_BINORMAL_EXT = 0x843C;
        public const GLenum GL_TANGENT_ARRAY_TYPE_EXT = 0x843E;
        public const GLenum GL_TANGENT_ARRAY_STRIDE_EXT = 0x843F;
        public const GLenum GL_BINORMAL_ARRAY_TYPE_EXT = 0x8440;
        public const GLenum GL_BINORMAL_ARRAY_STRIDE_EXT = 0x8441;
        public const GLenum GL_TANGENT_ARRAY_POINTER_EXT = 0x8442;
        public const GLenum GL_BINORMAL_ARRAY_POINTER_EXT = 0x8443;
        public const GLenum GL_MAP1_TANGENT_EXT = 0x8444;
        public const GLenum GL_MAP2_TANGENT_EXT = 0x8445;
        public const GLenum GL_MAP1_BINORMAL_EXT = 0x8446;
        public const GLenum GL_MAP2_BINORMAL_EXT = 0x8447;
    }
}
#endif