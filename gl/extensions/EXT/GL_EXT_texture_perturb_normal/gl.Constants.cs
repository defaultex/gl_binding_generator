#if (GL_EXT_texture_perturb_normal && GL_API)
public partial class ext { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PERTURB_EXT = 0x85AE;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_NORMAL_EXT = 0x85AF;
#endif
    }
}
#endif