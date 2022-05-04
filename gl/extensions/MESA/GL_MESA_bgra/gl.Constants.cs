#if (GL_MESA_bgra && GLES2_API)
public partial class mesa { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_BGR_EXT = 0x80E0;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_BGRA_EXT = 0x80E1;
#endif
    }
}
#endif