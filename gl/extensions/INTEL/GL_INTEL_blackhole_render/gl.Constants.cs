#if (GL_INTEL_blackhole_render && (!gl || !glcore || !gles2))
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_BLACKHOLE_RENDER_INTEL = 0x83FC;
    }
}
#endif