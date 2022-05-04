#if (GL_MESA_program_binary_formats && (GL_API || GLES2_API))
public partial class mesa { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PROGRAM_BINARY_FORMAT_MESA = 0x875F;
#endif
    }
}
#endif