#if (GL_NV_depth_clamp && GL_API)
public partial class nv { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_DEPTH_CLAMP_NV = 0x864F;
#endif
    }
}
#endif