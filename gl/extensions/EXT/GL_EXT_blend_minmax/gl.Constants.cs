#if (GL_EXT_blend_minmax && (GL_API || GLES1_API || GLES2_API))
public partial class ext { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_FUNC_ADD_EXT = 0x8006;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MIN_EXT = 0x8007;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_EXT = 0x8008;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_BLEND_EQUATION_EXT = 0x8009;
#endif
    }
}
#endif