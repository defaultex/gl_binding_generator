#if (GL_EXT_provoking_vertex && GL_API)
public partial class ext { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_QUADS_FOLLOW_PROVOKING_VERTEX_CONVENTION_EXT = 0x8E4C;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_FIRST_VERTEX_CONVENTION_EXT = 0x8E4D;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_LAST_VERTEX_CONVENTION_EXT = 0x8E4E;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PROVOKING_VERTEX_EXT = 0x8E4F;
#endif
    }
}
#endif