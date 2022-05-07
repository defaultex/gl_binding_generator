#if (GL_INTEL_parallel_arrays && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_PARALLEL_ARRAYS_INTEL = 0x83F4;
        public const GLenum GL_VERTEX_ARRAY_PARALLEL_POINTERS_INTEL = 0x83F5;
        public const GLenum GL_NORMAL_ARRAY_PARALLEL_POINTERS_INTEL = 0x83F6;
        public const GLenum GL_COLOR_ARRAY_PARALLEL_POINTERS_INTEL = 0x83F7;
        public const GLenum GL_TEXTURE_COORD_ARRAY_PARALLEL_POINTERS_INTEL = 0x83F8;
    }
}
#endif