#if (GL_EXT_clip_volume_hint && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_CLIP_VOLUME_CLIPPING_HINT_EXT = 0x80F0;
    }
}
#endif