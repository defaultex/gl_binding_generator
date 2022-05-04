#if (GL_SGIS_point_line_texgen && GL_API)
public partial class sgis { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_EYE_DISTANCE_TO_POINT_SGIS = 0x81F0;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_OBJECT_DISTANCE_TO_POINT_SGIS = 0x81F1;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_EYE_DISTANCE_TO_LINE_SGIS = 0x81F2;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_OBJECT_DISTANCE_TO_LINE_SGIS = 0x81F3;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_EYE_POINT_SGIS = 0x81F4;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_OBJECT_POINT_SGIS = 0x81F5;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_EYE_LINE_SGIS = 0x81F6;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_OBJECT_LINE_SGIS = 0x81F7;
#endif
    }
}
#endif