#if (GL_NV_texture_expand_normal && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_TEXTURE_UNSIGNED_REMAP_MODE_NV = 0x888F;
    }
}
#endif