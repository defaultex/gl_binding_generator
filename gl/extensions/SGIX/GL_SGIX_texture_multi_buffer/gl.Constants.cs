#if (GL_SGIX_texture_multi_buffer && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_TEXTURE_MULTI_BUFFER_HINT_SGIX = 0x812E;
    }
}
#endif