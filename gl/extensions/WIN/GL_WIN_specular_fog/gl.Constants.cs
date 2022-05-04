#if (GL_WIN_specular_fog && GL_API)
public partial class win { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_FOG_SPECULAR_TEXTURE_WIN = 0x80EC;
#endif
    }
}
#endif