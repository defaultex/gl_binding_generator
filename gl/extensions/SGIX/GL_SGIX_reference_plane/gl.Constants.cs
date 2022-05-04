#if (GL_SGIX_reference_plane && GL_API)
public partial class sgix { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_REFERENCE_PLANE_SGIX = 0x817D;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_REFERENCE_PLANE_EQUATION_SGIX = 0x817E;
#endif
    }
}
#endif