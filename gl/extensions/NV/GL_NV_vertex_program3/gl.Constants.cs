#if (GL_NV_vertex_program3 && GL_API)
public partial class nv { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_VERTEX_TEXTURE_IMAGE_UNITS_ARB = 0x8B4C;
#endif
    }
}
#endif