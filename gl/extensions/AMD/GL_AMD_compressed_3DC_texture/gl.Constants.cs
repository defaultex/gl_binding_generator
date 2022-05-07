#if (GL_AMD_compressed_3DC_texture && (!gles1 || !gles2))
public partial class gles1 { 
    public partial class Constants { 
        public const GLenum GL_3DC_X_AMD = 0x87F9;
        public const GLenum GL_3DC_XY_AMD = 0x87FA;
    }
}
#endif