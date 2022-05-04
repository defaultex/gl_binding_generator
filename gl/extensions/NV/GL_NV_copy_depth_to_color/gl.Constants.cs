#if (GL_NV_copy_depth_to_color && GL_API)
public partial class nv { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_DEPTH_STENCIL_TO_RGBA_NV = 0x886E;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_DEPTH_STENCIL_TO_BGRA_NV = 0x886F;
#endif
    }
}
#endif