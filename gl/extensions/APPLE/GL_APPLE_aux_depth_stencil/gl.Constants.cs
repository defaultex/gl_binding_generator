#if (GL_APPLE_aux_depth_stencil && GL_API)
public partial class apple { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_AUX_DEPTH_STENCIL_APPLE = 0x8A14;
#endif
    }
}
#endif