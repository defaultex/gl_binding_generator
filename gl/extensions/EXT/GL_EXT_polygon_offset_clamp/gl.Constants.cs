#if (GL_EXT_polygon_offset_clamp && (GL_API || GLCORE_API || GLES2_API))
public partial class ext { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_POLYGON_OFFSET_CLAMP_EXT = 0x8E1B;
#endif
    }
}
#endif