#if (GL_OES_texture_float && GLES2_API)
public partial class oes { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_FLOAT = 0x1406;
#endif
    }
}
#endif