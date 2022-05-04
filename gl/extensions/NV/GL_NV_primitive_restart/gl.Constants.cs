#if (GL_NV_primitive_restart && GL_API)
public partial class nv { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PRIMITIVE_RESTART_NV = 0x8558;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PRIMITIVE_RESTART_INDEX_NV = 0x8559;
#endif
    }
}
#endif