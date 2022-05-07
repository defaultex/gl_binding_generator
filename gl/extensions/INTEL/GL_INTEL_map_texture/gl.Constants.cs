#if (GL_INTEL_map_texture && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_LAYOUT_DEFAULT_INTEL = 0;
        public const GLenum GL_LAYOUT_LINEAR_INTEL = 1;
        public const GLenum GL_LAYOUT_LINEAR_CPU_CACHED_INTEL = 2;
        public const GLenum GL_TEXTURE_MEMORY_LAYOUT_INTEL = 0x83FF;
    }
}
#endif