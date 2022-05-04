#if (GL_EXT_texture_type_2_10_10_10_REV && GLES2_API)
public partial class ext { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_UNSIGNED_INT_2_10_10_10_REV_EXT = 0x8368;
#endif
    }
}
#endif