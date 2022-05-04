#if (GL_SGIX_shadow_ambient && GL_API)
public partial class sgix { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SHADOW_AMBIENT_SGIX = 0x80BF;
#endif
    }
}
#endif