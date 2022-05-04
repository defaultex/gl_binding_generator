#if (GL_APPLE_transform_hint && GL_API)
public partial class apple { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TRANSFORM_HINT_APPLE = 0x85B1;
#endif
    }
}
#endif