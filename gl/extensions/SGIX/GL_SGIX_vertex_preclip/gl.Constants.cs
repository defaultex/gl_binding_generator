#if (GL_SGIX_vertex_preclip && GL_API)
public partial class sgix { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_VERTEX_PRECLIP_SGIX = 0x83EE;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_VERTEX_PRECLIP_HINT_SGIX = 0x83EF;
#endif
    }
}
#endif