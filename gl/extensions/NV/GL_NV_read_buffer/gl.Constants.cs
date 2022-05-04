#if (GL_NV_read_buffer && GLES2_API)
public partial class nv { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_READ_BUFFER_NV = 0x0C02;
#endif
    }
}
#endif