#if (GL_ARB_texture_mirrored_repeat && (GL_API || GLCORE_API))
public partial class arb { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MIRRORED_REPEAT_ARB = 0x8370;
#endif
    }
}
#endif