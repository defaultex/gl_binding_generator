#if (GL_ATI_pn_triangles && GL_API)
public partial class ati { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PN_TRIANGLES_ATI = 0x87F0;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_PN_TRIANGLES_TESSELATION_LEVEL_ATI = 0x87F1;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PN_TRIANGLES_POINT_MODE_ATI = 0x87F2;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PN_TRIANGLES_NORMAL_MODE_ATI = 0x87F3;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PN_TRIANGLES_TESSELATION_LEVEL_ATI = 0x87F4;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PN_TRIANGLES_POINT_MODE_LINEAR_ATI = 0x87F5;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PN_TRIANGLES_POINT_MODE_CUBIC_ATI = 0x87F6;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PN_TRIANGLES_NORMAL_MODE_LINEAR_ATI = 0x87F7;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PN_TRIANGLES_NORMAL_MODE_QUADRATIC_ATI = 0x87F8;
#endif
    }
}
#endif