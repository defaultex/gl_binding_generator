#if (GL_EXT_cull_vertex && GL_API)
public partial class ext { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_CULL_VERTEX_EXT = 0x81AA;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_CULL_VERTEX_EYE_POSITION_EXT = 0x81AB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_CULL_VERTEX_OBJECT_POSITION_EXT = 0x81AC;
#endif
    }
}
#endif