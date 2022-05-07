#if (GL_ARB_texture_rgb10_a2ui && (!gl || !glcore))
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_RGB10_A2UI = 0x906F;
    }
}
#endif