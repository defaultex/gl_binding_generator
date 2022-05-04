#if (GL_EXT_texture_mirror_clamp_to_edge && GLES2_API)
public partial class ext { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MIRROR_CLAMP_TO_EDGE_EXT = 0x8743;
#endif
    }
}
#endif