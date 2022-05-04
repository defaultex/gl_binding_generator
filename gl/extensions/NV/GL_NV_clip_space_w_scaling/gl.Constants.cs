#if (GL_NV_clip_space_w_scaling && (GL_API || GLCORE_API || GLES2_API))
public partial class nv { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_VIEWPORT_POSITION_W_SCALE_NV = 0x937C;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_VIEWPORT_POSITION_W_SCALE_X_COEFF_NV = 0x937D;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_VIEWPORT_POSITION_W_SCALE_Y_COEFF_NV = 0x937E;
#endif
    }
}
#endif