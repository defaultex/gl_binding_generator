#if (GL_ARB_bindless_texture && (!gl || !glcore))
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_UNSIGNED_INT64_ARB = 0x140F;
    }
}
#endif