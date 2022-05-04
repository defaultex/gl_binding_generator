#if (GL_INTEL_parallel_arrays && GL_API)
public partial class intel { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PARALLEL_ARRAYS_INTEL = 0x83F4;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_VERTEX_ARRAY_PARALLEL_POINTERS_INTEL = 0x83F5;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_NORMAL_ARRAY_PARALLEL_POINTERS_INTEL = 0x83F6;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_COLOR_ARRAY_PARALLEL_POINTERS_INTEL = 0x83F7;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_COORD_ARRAY_PARALLEL_POINTERS_INTEL = 0x83F8;
#endif
    }
}
#endif