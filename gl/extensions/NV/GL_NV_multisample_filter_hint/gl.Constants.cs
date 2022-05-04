#if (GL_NV_multisample_filter_hint && GL_API)
public partial class nv { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MULTISAMPLE_FILTER_HINT_NV = 0x8534;
#endif
    }
}
#endif