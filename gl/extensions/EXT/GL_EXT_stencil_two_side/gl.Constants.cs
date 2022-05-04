#if (GL_EXT_stencil_two_side && GL_API)
public partial class ext { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_STENCIL_TEST_TWO_SIDE_EXT = 0x8910;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_ACTIVE_STENCIL_FACE_EXT = 0x8911;
#endif
    }
}
#endif