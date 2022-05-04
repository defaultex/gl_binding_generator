#if (GL_EXT_polygon_offset && GL_API)
public partial class ext { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_POLYGON_OFFSET_EXT = 0x8037;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_POLYGON_OFFSET_FACTOR_EXT = 0x8038;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_POLYGON_OFFSET_BIAS_EXT = 0x8039;
#endif
    }
}
#endif