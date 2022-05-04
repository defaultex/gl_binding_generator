#if (GL_SGIX_clipmap && GL_API)
public partial class sgix { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_LINEAR_CLIPMAP_LINEAR_SGIX = 0x8170;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_CLIPMAP_CENTER_SGIX = 0x8171;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_CLIPMAP_FRAME_SGIX = 0x8172;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_CLIPMAP_OFFSET_SGIX = 0x8173;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_CLIPMAP_VIRTUAL_DEPTH_SGIX = 0x8174;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_CLIPMAP_LOD_OFFSET_SGIX = 0x8175;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_CLIPMAP_DEPTH_SGIX = 0x8176;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_CLIPMAP_DEPTH_SGIX = 0x8177;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_CLIPMAP_VIRTUAL_DEPTH_SGIX = 0x8178;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_NEAREST_CLIPMAP_NEAREST_SGIX = 0x844D;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_NEAREST_CLIPMAP_LINEAR_SGIX = 0x844E;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_LINEAR_CLIPMAP_NEAREST_SGIX = 0x844F;
#endif
    }
}
#endif