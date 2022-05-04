#if (GL_NV_texture_shader2 && GL_API)
public partial class nv { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_DOT_PRODUCT_TEXTURE_3D_NV = 0x86EF;
#endif
    }
}
#endif