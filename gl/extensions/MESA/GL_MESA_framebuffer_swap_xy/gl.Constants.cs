#if (GL_MESA_framebuffer_swap_xy && (GL_API || GLCORE_API || GLES2_API))
public partial class mesa { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_FRAMEBUFFER_SWAP_XY_MESA = 0x8BBD;
#endif
    }
}
#endif