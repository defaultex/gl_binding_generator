#if (GL_EXT_timer_query && GL_API)
public partial class ext { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TIME_ELAPSED_EXT = 0x88BF;
#endif
    }
}
#endif