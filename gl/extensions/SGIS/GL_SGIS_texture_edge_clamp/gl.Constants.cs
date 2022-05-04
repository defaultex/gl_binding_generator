#if (GL_SGIS_texture_edge_clamp && GL_API)
public partial class sgis { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_CLAMP_TO_EDGE_SGIS = 0x812F;
#endif
    }
}
#endif