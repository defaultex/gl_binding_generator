#if (GL_NV_depth_nonlinear && GLES2_API)
public partial class nv { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_DEPTH_COMPONENT16_NONLINEAR_NV = 0x8E2C;
#endif
    }
}
#endif