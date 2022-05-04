#if (GL_EXT_abgr && GL_API)
public partial class ext { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_ABGR_EXT = 0x8000;
#endif
    }
}
#endif