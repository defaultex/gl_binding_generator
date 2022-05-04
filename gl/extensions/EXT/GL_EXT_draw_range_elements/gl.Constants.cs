#if (GL_EXT_draw_range_elements && GL_API)
public partial class ext { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_ELEMENTS_VERTICES_EXT = 0x80E8;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_ELEMENTS_INDICES_EXT = 0x80E9;
#endif
    }
}
#endif