#if (GL_NV_copy_buffer && GLES2_API)
public partial class nv { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_COPY_READ_BUFFER_NV = 0x8F36;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_COPY_WRITE_BUFFER_NV = 0x8F37;
#endif
    }
}
#endif