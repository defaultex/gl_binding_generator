#if (GL_APPLE_transform_hint && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_TRANSFORM_HINT_APPLE = 0x85B1;
    }
}
#endif