#if (GL_APPLE_fence && GL_API)
public partial class apple { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_DRAW_PIXELS_APPLE = 0x8A0A;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_FENCE_APPLE = 0x8A0B;
#endif
    }
}
#endif