#if (GL_APPLE_object_purgeable && GL_API)
public partial class glext_apple { 
    public partial class Constants { 
        public const GLenum GL_BUFFER_OBJECT_APPLE = 0x85B3;
        public const GLenum GL_RELEASED_APPLE = 0x8A19;
        public const GLenum GL_VOLATILE_APPLE = 0x8A1A;
        public const GLenum GL_RETAINED_APPLE = 0x8A1B;
        public const GLenum GL_UNDEFINED_APPLE = 0x8A1C;
        public const GLenum GL_PURGEABLE_APPLE = 0x8A1D;
    }
}
#endif