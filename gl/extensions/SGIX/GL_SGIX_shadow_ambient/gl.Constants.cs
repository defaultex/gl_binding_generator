#if (GL_SGIX_shadow_ambient && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_SHADOW_AMBIENT_SGIX = 0x80BF;
    }
}
#endif