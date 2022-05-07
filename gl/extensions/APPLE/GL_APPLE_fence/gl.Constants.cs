#if (GL_APPLE_fence && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_DRAW_PIXELS_APPLE = 0x8A0A;
        public const GLenum GL_FENCE_APPLE = 0x8A0B;
    }
}
#endif