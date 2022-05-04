#if (GL_SGIX_fog_offset && GL_API)
public partial class sgix { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_FOG_OFFSET_SGIX = 0x8198;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_FOG_OFFSET_VALUE_SGIX = 0x8199;
#endif
    }
}
#endif