#if (GL_MESA_pack_invert && GL_API)
public partial class mesa { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PACK_INVERT_MESA = 0x8758;
#endif
    }
}
#endif