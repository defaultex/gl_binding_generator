#if (GL_EXT_blend_subtract && GL_API)
public partial class ext { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_FUNC_SUBTRACT_EXT = 0x800A;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_FUNC_REVERSE_SUBTRACT_EXT = 0x800B;
#endif
    }
}
#endif