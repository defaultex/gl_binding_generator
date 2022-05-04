#if (GL_INTEL_map_texture && GL_API)
public partial class intel { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_LAYOUT_DEFAULT_INTEL = 0;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_LAYOUT_LINEAR_INTEL = 1;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_LAYOUT_LINEAR_CPU_CACHED_INTEL = 2;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_MEMORY_LAYOUT_INTEL = 0x83FF;
#endif
    }
}
#endif