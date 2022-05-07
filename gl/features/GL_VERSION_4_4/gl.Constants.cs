#if (GL_VERSION_4_4 && GL_API)
public partial class gl { 
    public partial class Constants { 
        public const GLbitfield GL_MAP_PERSISTENT_BIT = 0x0040;
        public const GLbitfield GL_MAP_COHERENT_BIT = 0x0080;
        public const GLbitfield GL_DYNAMIC_STORAGE_BIT = 0x0100;
        public const GLbitfield GL_CLIENT_STORAGE_BIT = 0x0200;
        public const GLbitfield GL_CLIENT_MAPPED_BUFFER_BARRIER_BIT = 0x00004000;
        public const GLbitfield GL_QUERY_BUFFER_BARRIER_BIT = 0x00008000;
        public const GLenum GL_BUFFER_IMMUTABLE_STORAGE = 0x821F;
        public const GLenum GL_BUFFER_STORAGE_FLAGS = 0x8220;
        public const GLenum GL_PRIMITIVE_RESTART_FOR_PATCHES_SUPPORTED = 0x8221;
        public const GLenum GL_MAX_VERTEX_ATTRIB_STRIDE = 0x82E5;
        public const GLenum GL_MIRROR_CLAMP_TO_EDGE = 0x8743;
        public const GLenum GL_TEXTURE_BUFFER_BINDING = 0x8C2A;
        public const GLenum GL_QUERY_BUFFER = 0x9192;
        public const GLenum GL_QUERY_BUFFER_BINDING = 0x9193;
        public const GLenum GL_QUERY_RESULT_NO_WAIT = 0x9194;
        public const GLenum GL_LOCATION_COMPONENT = 0x934A;
        public const GLenum GL_TRANSFORM_FEEDBACK_BUFFER_INDEX = 0x934B;
        public const GLenum GL_TRANSFORM_FEEDBACK_BUFFER_STRIDE = 0x934C;
        public const GLenum GL_CLEAR_TEXTURE = 0x9365;
    }
}
#endif