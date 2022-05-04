#if (GL_OML_subsample && GL_API)
public partial class oml { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_FORMAT_SUBSAMPLE_24_24_OML = 0x8982;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_FORMAT_SUBSAMPLE_244_244_OML = 0x8983;
#endif
    }
}
#endif