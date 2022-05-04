#if (GL_IBM_texture_mirrored_repeat && GL_API)
public partial class ibm { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MIRRORED_REPEAT_IBM = 0x8370;
#endif
    }
}
#endif