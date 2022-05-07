#if (GL_ARB_map_buffer_alignment && (!gl || !glcore))
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_MIN_MAP_BUFFER_ALIGNMENT = 0x90BC;
    }
}
#endif