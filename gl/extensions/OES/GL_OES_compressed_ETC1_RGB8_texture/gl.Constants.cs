#if (GL_OES_compressed_ETC1_RGB8_texture && (GLES1_API || GLES2_API))
public partial class oes { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_ETC1_RGB8_OES = 0x8D64;
#endif
    }
}
#endif