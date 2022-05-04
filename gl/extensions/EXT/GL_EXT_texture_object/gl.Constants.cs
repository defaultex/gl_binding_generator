#if (GL_EXT_texture_object && GL_API)
public partial class ext { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_PRIORITY_EXT = 0x8066;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_RESIDENT_EXT = 0x8067;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_1D_BINDING_EXT = 0x8068;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_2D_BINDING_EXT = 0x8069;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_3D_BINDING_EXT = 0x806A;
#endif
    }
}
#endif