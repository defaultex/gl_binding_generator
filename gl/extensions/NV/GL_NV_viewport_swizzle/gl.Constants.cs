#if (GL_NV_viewport_swizzle && (GL_API || GLCORE_API || GLES2_API))
public partial class nv { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_VIEWPORT_SWIZZLE_POSITIVE_X_NV = 0x9350;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_VIEWPORT_SWIZZLE_NEGATIVE_X_NV = 0x9351;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_VIEWPORT_SWIZZLE_POSITIVE_Y_NV = 0x9352;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_VIEWPORT_SWIZZLE_NEGATIVE_Y_NV = 0x9353;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_VIEWPORT_SWIZZLE_POSITIVE_Z_NV = 0x9354;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_VIEWPORT_SWIZZLE_NEGATIVE_Z_NV = 0x9355;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_VIEWPORT_SWIZZLE_POSITIVE_W_NV = 0x9356;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_VIEWPORT_SWIZZLE_NEGATIVE_W_NV = 0x9357;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_VIEWPORT_SWIZZLE_X_NV = 0x9358;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_VIEWPORT_SWIZZLE_Y_NV = 0x9359;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_VIEWPORT_SWIZZLE_Z_NV = 0x935A;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_VIEWPORT_SWIZZLE_W_NV = 0x935B;
#endif
    }
}
#endif