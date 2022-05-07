#if (GL_EXT_x11_sync_object && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_SYNC_X11_FENCE_EXT = 0x90E1;
    }
}
#endif