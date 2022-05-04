#if (GL_OES_mapbuffer && (GLES1_API || GLES2_API))
public partial class oes { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_WRITE_ONLY_OES = 0x88B9;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_BUFFER_ACCESS_OES = 0x88BB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_BUFFER_MAPPED_OES = 0x88BC;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_BUFFER_MAP_POINTER_OES = 0x88BD;
#endif
    }
}
#endif