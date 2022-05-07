#if (GL_EXT_timer_query && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_TIME_ELAPSED_EXT = 0x88BF;
    }
}
#endif