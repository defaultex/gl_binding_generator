#if (GL_SGIX_scalebias_hint && GL_API)
public partial class sgix { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SCALEBIAS_HINT_SGIX = 0x8322;
#endif
    }
}
#endif