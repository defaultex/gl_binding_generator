#if (GL_SUN_slice_accum && GL_API)
public partial class sun { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SLICE_ACCUM_SUN = 0x85CC;
#endif
    }
}
#endif