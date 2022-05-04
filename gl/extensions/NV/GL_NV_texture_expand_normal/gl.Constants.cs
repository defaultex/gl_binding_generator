#if (GL_NV_texture_expand_normal && GL_API)
public partial class nv { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_UNSIGNED_REMAP_MODE_NV = 0x888F;
#endif
    }
}
#endif