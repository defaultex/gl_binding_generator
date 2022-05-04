#if (GL_NV_polygon_mode && GLES2_API)
public partial class nv { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_POLYGON_MODE_NV = 0x0B40;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_POINT_NV = 0x1B00;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_LINE_NV = 0x1B01;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_FILL_NV = 0x1B02;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_POLYGON_OFFSET_POINT_NV = 0x2A01;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_POLYGON_OFFSET_LINE_NV = 0x2A02;
#endif
    }
}
#endif