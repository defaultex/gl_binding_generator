#if (GL_EXT_rescale_normal && GL_API)
public partial class ext { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_RESCALE_NORMAL_EXT = 0x803A;
#endif
    }
}
#endif