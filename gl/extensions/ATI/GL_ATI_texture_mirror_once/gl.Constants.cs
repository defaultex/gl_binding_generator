#if (GL_ATI_texture_mirror_once && GL_API)
public partial class ati { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MIRROR_CLAMP_ATI = 0x8742;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MIRROR_CLAMP_TO_EDGE_ATI = 0x8743;
#endif
    }
}
#endif