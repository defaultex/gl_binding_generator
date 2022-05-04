#if (GL_EXT_depth_clamp && GLES2_API)
public partial class ext { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_DEPTH_CLAMP_EXT = 0x864F;
#endif
    }
}
#endif