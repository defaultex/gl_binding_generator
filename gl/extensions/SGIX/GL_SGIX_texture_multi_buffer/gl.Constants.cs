#if (GL_SGIX_texture_multi_buffer && GL_API)
public partial class sgix { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_MULTI_BUFFER_HINT_SGIX = 0x812E;
#endif
    }
}
#endif