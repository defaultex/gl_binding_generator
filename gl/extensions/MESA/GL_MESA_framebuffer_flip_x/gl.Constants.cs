#if (GL_MESA_framebuffer_flip_x && (GL_API || GLCORE_API || GLES2_API))
public partial class mesa { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_FRAMEBUFFER_FLIP_X_MESA = 0x8BBC;
#endif
    }
}
#endif