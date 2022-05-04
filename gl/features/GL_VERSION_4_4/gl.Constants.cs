#if (GL_VERSION_4_4 && GL_API)
public partial class gl { 
    public partial class Constants { 

#if (!GL_SC_VERSION_2_0)
        public const GLbitfield GL_MAP_READ_BIT = 0x0001;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLbitfield GL_MAP_WRITE_BIT = 0x0002;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLbitfield GL_MAP_PERSISTENT_BIT = 0x0040;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLbitfield GL_MAP_COHERENT_BIT = 0x0080;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLbitfield GL_DYNAMIC_STORAGE_BIT = 0x0100;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLbitfield GL_CLIENT_STORAGE_BIT = 0x0200;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_STENCIL_INDEX = 0x1901;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLbitfield GL_CLIENT_MAPPED_BUFFER_BARRIER_BIT = 0x00004000;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLbitfield GL_QUERY_BUFFER_BARRIER_BIT = 0x00008000;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_BUFFER_IMMUTABLE_STORAGE = 0x821F;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_BUFFER_STORAGE_FLAGS = 0x8220;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_PRIMITIVE_RESTART_FOR_PATCHES_SUPPORTED = 0x8221;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_VERTEX_ATTRIB_STRIDE = 0x82E5;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MIRROR_CLAMP_TO_EDGE = 0x8743;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_TEXTURE_BUFFER_BINDING = 0x8C2A;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_UNSIGNED_INT_10F_11F_11F_REV = 0x8C3B;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_TRANSFORM_FEEDBACK_BUFFER = 0x8C8E;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_STENCIL_INDEX8 = 0x8D48;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_QUERY_BUFFER = 0x9192;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_QUERY_BUFFER_BINDING = 0x9193;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_QUERY_RESULT_NO_WAIT = 0x9194;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_LOCATION_COMPONENT = 0x934A;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_TRANSFORM_FEEDBACK_BUFFER_INDEX = 0x934B;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_TRANSFORM_FEEDBACK_BUFFER_STRIDE = 0x934C;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_CLEAR_TEXTURE = 0x9365;
#endif
    }
}
#endif