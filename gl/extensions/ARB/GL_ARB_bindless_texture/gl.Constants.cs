#if (GL_ARB_bindless_texture && (GL_API || GLCORE_API))
public partial class arb { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_UNSIGNED_INT64_ARB = 0x140F;
#endif
    }
}
#endif