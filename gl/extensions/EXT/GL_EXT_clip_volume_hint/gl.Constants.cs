#if (GL_EXT_clip_volume_hint && GL_API)
public partial class ext { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_CLIP_VOLUME_CLIPPING_HINT_EXT = 0x80F0;
#endif
    }
}
#endif