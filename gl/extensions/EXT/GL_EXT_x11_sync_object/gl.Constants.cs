#if (GL_EXT_x11_sync_object && GL_API)
public partial class ext { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SYNC_X11_FENCE_EXT = 0x90E1;
#endif
    }
}
#endif