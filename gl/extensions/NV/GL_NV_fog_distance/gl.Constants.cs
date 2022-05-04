#if (GL_NV_fog_distance && GL_API)
public partial class nv { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_EYE_PLANE = 0x2502;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_FOG_DISTANCE_MODE_NV = 0x855A;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_EYE_RADIAL_NV = 0x855B;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_EYE_PLANE_ABSOLUTE_NV = 0x855C;
#endif
    }
}
#endif