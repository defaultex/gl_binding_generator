#if (GL_OES_vertex_type_10_10_10_2 && GLES2_API)
public partial class oes { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_UNSIGNED_INT_10_10_10_2_OES = 0x8DF6;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_INT_10_10_10_2_OES = 0x8DF7;
#endif
    }
}
#endif