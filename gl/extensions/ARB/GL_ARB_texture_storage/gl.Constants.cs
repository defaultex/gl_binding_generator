#if (GL_ARB_texture_storage && (!gl || !glcore))
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_TEXTURE_IMMUTABLE_FORMAT = 0x912F;
    }
}
#endif