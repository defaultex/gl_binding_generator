#if (GL_WIN_phong_shading && GL_API)
public partial class win { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PHONG_WIN = 0x80EA;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PHONG_HINT_WIN = 0x80EB;
#endif
    }
}
#endif