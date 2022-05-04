#if (GL_AMD_compressed_3DC_texture && (GLES1_API || GLES2_API))
public partial class amd { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_3DC_X_AMD = 0x87F9;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_3DC_XY_AMD = 0x87FA;
#endif
    }
}
#endif