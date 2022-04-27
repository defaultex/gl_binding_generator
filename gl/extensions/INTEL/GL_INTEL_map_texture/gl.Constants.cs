#if (GL_INTEL_map_texture && GL_API)
public partial class glext_intel { 
    public partial class Constants { 
        public const GLenum GL_LAYOUT_DEFAULT_INTEL = 0;
        public const GLenum GL_LAYOUT_LINEAR_INTEL = 1;
        public const GLenum GL_LAYOUT_LINEAR_CPU_CACHED_INTEL = 2;
        public const GLenum GL_TEXTURE_MEMORY_LAYOUT_INTEL = 0x83FF;
    }
}
#endif